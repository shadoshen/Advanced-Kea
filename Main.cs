using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using Kea.CommonFiles; // Import of updated models
using Newtonsoft.Json.Linq;

namespace Kea
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public List<ToonListEntry> ToonList;
        public string SaveAs;

        private static readonly HttpClient HttpClient;

        static Main()
        {
            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = new CookieContainer(),
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            handler.CookieContainer.Add(new Uri("https://www.webtoons.com"), new Cookie("pagGDPR", "true"));

            HttpClient = new HttpClient(handler);
            HttpClient.DefaultRequestHeaders.Add("User-Agent", Globals.SpoofedUserAgent);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Main()
        {
            Globals.LoadSettings(); // Loads saved settings at startup
            InitializeComponent();
            QueueGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SaveAsOption.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Additional initializations if necessary
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            using (var settings = new SettingsForm())
            {
                settings.ShowDialog(this);
            }
        }

        private void HandleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AddToQueueBtn_Click(object sender, EventArgs e)
        {
            string[] lines = URLTextbox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string lineRaw in lines)
            {
                string line = lineRaw.Trim();

                if (!line.Contains("https://www.webtoons.com/") || !line.Contains("/list?title_no=")) continue;

                if (!Uri.TryCreate(line, UriKind.Absolute, out Uri lineUri)) continue;

                string toonName = lineUri.Segments.Length >= 4 ? lineUri.Segments[3].TrimEnd('/') : string.Empty;
                if (string.IsNullOrEmpty(toonName)) continue;

                var query = HttpUtility.ParseQueryString(lineUri.Query);
                if (!int.TryParse(query.Get("title_no"), out int titleNo)) continue;

                string languageCode = query.Get("language");
                if (Helpers.IsStringEmptyNullOrWhiteSpace(languageCode))
                {
                    languageCode = "default";
                }
                else
                {
                    line = Helpers.RemoveQueryStringByKey(line, "language");
                }

                string teamVersion = query.Get("teamVersion");
                if (Helpers.IsStringEmptyNullOrWhiteSpace(teamVersion))
                {
                    teamVersion = "default";
                }
                else
                {
                    line = Helpers.RemoveQueryStringByKey(line, "teamVersion");
                }

                if (languageCode == "default" && teamVersion != "default")
                {
                    MessageBox.Show("default language can't have a team version.");
                    continue;
                }

                bool exists = QueueGrid.Rows.Cast<DataGridViewRow>().Any(row =>
                    row.Cells["titleName"].Value?.ToString() == toonName &&
                    row.Cells["titleNo"].Value?.ToString() == titleNo.ToString() &&
                    row.Cells["titleTranslationLanguageCode"].Value?.ToString() == languageCode &&
                    row.Cells["titleTranslationTeamVersion"].Value?.ToString() == teamVersion
                );

                if (!exists)
                {
                    QueueGrid.Rows.Add(titleNo, toonName, "1", "end", languageCode, teamVersion, line);
                }
            }
            URLTextbox.Text = "";
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            DisableAllControls(this);

            Label7.Text = "AdvancedKea (Scraping in progress...)";
            EnableControls(Label7);
            Label7.ForeColor = Color.LightGray;

            SaveAs = SaveAsOption.Text;

            if (SkipDownloadedChaptersCB.Checked && SaveAs == "multiple images")
            {
                MessageBox.Show("Skipping downloaded chapters cannot be used while saving as \"multiple images\"");
                ResetTitleUI();
                EnableAllControls(this);
                return;
            }

            bool wasWarned = false;
            foreach (DataGridViewRow r in QueueGrid.Rows)
            {
                if (r.IsNewRow) continue;

                if (!int.TryParse(r.Cells["titleEpBegin"].Value?.ToString(), out int start) || start < 1)
                {
                    MessageBox.Show("The start chapter must be a number greater than zero!");
                    ResetTitleUI();
                    EnableAllControls(this);
                    return;
                }

                string endVal = r.Cells["titleEpEnd"].Value?.ToString();
                int end = 0;
                if (endVal != "end")
                {
                    if (!int.TryParse(endVal, out end) || end < 1)
                    {
                        MessageBox.Show("The end chapter must be a number greater than zero or 'end'!");
                        ResetTitleUI();
                        EnableAllControls(this);
                        return;
                    }
                }

                if (end != 0 && end < start)
                {
                    MessageBox.Show("The start chapter must be smaller than the end chapter!");
                    ResetTitleUI();
                    EnableAllControls(this);
                    return;
                }

                if (!wasWarned && HighestQualityCB.Checked && r.Cells["titleTranslationLanguageCode"].Value?.ToString() != "default")
                {
                    MessageBox.Show("Warning! High quality options will be ignored for fan translations.");
                    wasWarned = true;
                }
            }

            EnableControls(HandleBar);
            EnableControls(ExitBtn);
            EnableControls(MinimizeBtn);

            await DownloadQueueAsync();

            ResetTitleUI();
            EnableAllControls(this);
            if (SaveAs != "multiple images") ChapterFoldersCB.Enabled = false;
        }

        private void ResetTitleUI()
        {
            Label7.Text = "AdvancedKea";
            Label7.ForeColor = Color.White;
        }

        private async Task DownloadQueueAsync()
        {
            if (!SavepathTB.Text.Contains('\\'))
            {
                SavepathTB.Text = "please select a directory for saving";
                return;
            }
            if (QueueGrid.Rows.Count == 0) return;

            ToonList = new List<ToonListEntry>();

            foreach (DataGridViewRow r in QueueGrid.Rows)
            {
                if (!r.IsNewRow)
                {
                    await GetChapterAsync(r);
                }
            }

            for (int t = 0; t < ToonList.Count; t++)
            {
                await DownloadComicAsync(ToonList[t]);
            }

            ProcessInfo.Text = "done!";
            ProgressBar.Value = ProgressBar.Minimum;
        }

        private async Task GetChapterAsync(DataGridViewRow r)
        {
            string line = r.Cells["titleUrl"].Value?.ToString();
            if (Helpers.IsStringEmptyNullOrWhiteSpace(line)) return;

            var currentToonEntry = new ToonListEntry();
            var toonEpisodeList = new List<EpisodeListEntry>();

            int urlEnd = (line.IndexOf('&') == -1) ? line.Length : line.IndexOf('&');
            line = line.Substring(0, urlEnd);
            Uri baseUri = new Uri(line);

            currentToonEntry.ToonInfo.TitleNo = Convert.ToInt32(r.Cells["titleNo"].Value);
            currentToonEntry.ToonInfo.ToonTitleName = r.Cells["titleName"].Value?.ToString();
            currentToonEntry.ToonInfo.StartDownloadAtEpisode = r.Cells["titleEpBegin"].Value?.ToString();
            currentToonEntry.ToonInfo.StopDownloadAtEpisode = r.Cells["titleEpEnd"].Value?.ToString();
            currentToonEntry.ToonInfo.ToonTranslationLanguageCode = r.Cells["titleTranslationLanguageCode"].Value?.ToString();
            currentToonEntry.ToonInfo.ToonTranslationTeamVersion = r.Cells["titleTranslationTeamVersion"].Value?.ToString();

            int i = 0;
            string nextPageUrl = line + "&page=1";
            int episodeBegin = int.Parse(currentToonEntry.ToonInfo.StartDownloadAtEpisode);
            int episodeEnd = (currentToonEntry.ToonInfo.StopDownloadAtEpisode == "end") ? -1 : int.Parse(currentToonEntry.ToonInfo.StopDownloadAtEpisode);

            while (true)
            {
                i++;
                ProcessInfo.Text = $"[ ({currentToonEntry.ToonInfo.TitleNo}) {currentToonEntry.ToonInfo.ToonTitleName} ] scoping tab {i}";

                string html = await HttpClient.GetStringAsync(nextPageUrl);
                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                var episodeNodes = htmlDoc.DocumentNode.SelectNodes(Globals.episodeListItemHtmlXPath);

                if (episodeNodes != null)
                {
                    foreach (var node in episodeNodes)
                    {
                        int episodeNo = -1;
                        if (node.Attributes["data-episode-no"] != null)
                        {
                            episodeNo = Convert.ToInt32(node.Attributes["data-episode-no"].Value);
                        }

                        HtmlNode innerANode = node.SelectSingleNode("./a");
                        string url = innerANode.Attributes["href"].Value;
                        string episodeTitle = innerANode.SelectSingleNode("./span[@class='subj']/span").InnerHtml;
                        string episodeSequence = innerANode.SelectSingleNode("./span[@class='tx']").InnerHtml;

                        if (episodeNo < episodeBegin || (episodeEnd != -1 && episodeNo > episodeEnd))
                        {
                            continue;
                        }

                        var currentEpisode = new EpisodeListEntry
                        {
                            EpisodeSequence = episodeSequence,
                            EpisodeNo = episodeNo,
                            EpisodeTitle = Helpers.SanitizeStringForFilePath(episodeTitle),
                            Url = url
                        };

                        toonEpisodeList.Add(currentEpisode);
                    }
                }

                string nextPage = GetWebsiteNextPageUrl(htmlDoc);
                if (Helpers.IsStringEmptyNullOrWhiteSpace(nextPage)) break;

                if (!Helpers.IsValidURL(nextPage))
                    nextPage = baseUri.GetLeftPart(UriPartial.Authority) + nextPage;

                nextPageUrl = nextPage;
            }

            toonEpisodeList.Reverse();
            currentToonEntry.EpisodeList = toonEpisodeList.ToArray();
            ToonList.Add(currentToonEntry);
        }

        private async Task DownloadComicAsync(ToonListEntry currentToon)
        {
            string baseSavePath = SavepathTB.Text.TrimEnd('\\') + @"\";
            string comicSavePath = baseSavePath + ToonHelpers.GetToonSavePath(currentToon.ToonInfo);

            if (CartoonFoldersCB.Checked)
            {
                comicSavePath += @"\";
                Directory.CreateDirectory(comicSavePath);
            }

            string suffix = (HighestQualityCB.Checked && currentToon.ToonInfo.ToonTranslationLanguageCode == "default") ? "[HQ]" : "";

            int startNr = 0;
            int endNr = currentToon.EpisodeList.Length;

            ProgressBar.Minimum = startNr * 100;
            ProgressBar.Maximum = endNr * 100;

            for (int i = startNr; i < endNr; i++)
            {
                int episodeNo = currentToon.EpisodeList[i].EpisodeNo;

                ProcessInfo.Text = $"[ ({currentToon.ToonInfo.TitleNo}) {currentToon.ToonInfo.ToonTitleName} ] grabbing the html of chapter {episodeNo}";
                try { ProgressBar.Value = i * 100; } catch { }

                string episodeSavePath = comicSavePath + ToonHelpers.GetToonEpisodeSavePath(currentToon.EpisodeList[i], suffix);
                string archiveSavePath = episodeSavePath;

                if (SkipDownloadedChaptersCB.Checked)
                {
                    string bundlePath = $"{archiveSavePath}{ToonHelpers.GetBundleExtension(SaveAs)}";
                    if (File.Exists(bundlePath))
                    {
                        ProcessInfo.Text = $"[ ({currentToon.ToonInfo.TitleNo}) {currentToon.ToonInfo.ToonTitleName} ] Skipping chapter {episodeNo}";
                        continue;
                    }
                }

                bool chapterDirectoryWasCreated = false;
                if (ChapterFoldersCB.Checked || SaveAs != "multiple images")
                {
                    episodeSavePath += @"\";
                    Directory.CreateDirectory(episodeSavePath);
                    chapterDirectoryWasCreated = true;
                }
                else
                {
                    episodeSavePath += "_";
                }

                var downloadedImages = new List<DownloadedToonChapterFileInfo>();
                int imageNo = 0;

                string html = await HttpClient.GetStringAsync(currentToon.EpisodeList[i].Url);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                List<string> imgUrlList = new List<string>();

                if (currentToon.ToonInfo.ToonTranslationLanguageCode == "default")
                {
                    var episodeImgs = doc.DocumentNode.SelectNodes(Globals.episodeImageHtmlXPath);
                    if (episodeImgs != null)
                    {
                        var imgList = episodeImgs.OrderBy(node => node.StreamPosition).ToArray();
                        foreach (HtmlNode imageNode in imgList)
                        {
                            imgUrlList.Add(imageNode.Attributes["data-url"].Value);
                        }
                    }
                }
                else
                {
                    string jsonResponse = await HttpClient.GetStringAsync($"{Globals.naverWebtoonAPIBaseUrl}/ctrans/translatedEpisodeLanguageInfo_jsonp.json?titleNo={currentToon.ToonInfo.TitleNo}&episodeNo={episodeNo}");
                    JObject o = JObject.Parse(jsonResponse);

                    string selectCondition = "@.languageCode == '" + currentToon.ToonInfo.ToonTranslationLanguageCode + "'";
                    if (currentToon.ToonInfo.ToonTranslationTeamVersion != "default")
                    {
                        selectCondition += " && @.teamVersion == " + currentToon.ToonInfo.ToonTranslationTeamVersion;
                    }

                    var languagesObject = o.SelectTokens("$.result.languageList[?(" + selectCondition + ")]").OrderByDescending(r => r["likeItCount"]);
                    JToken selectedTranslation = languagesObject.FirstOrDefault();

                    if (selectedTranslation != null)
                    {
                        string teamName = selectedTranslation["teamName"].ToString();
                        string teamVersion = selectedTranslation["teamVersion"].ToString();
                        string languageName = selectedTranslation["languageName"].ToString();

                        string imageListJsonResponse = await HttpClient.GetStringAsync($"{Globals.naverWebtoonAPIBaseUrl}/ctrans/translatedEpisodeDetail_jsonp.json?titleNo={currentToon.ToonInfo.TitleNo}&episodeNo={episodeNo}&languageCode={currentToon.ToonInfo.ToonTranslationLanguageCode}&teamVersion={teamVersion}");
                        JObject imageListO = JObject.Parse(imageListJsonResponse);
                        var imageInfo = imageListO.SelectTokens("$.result.imageInfo[*]").OrderBy(r => r["sortOrder"]);

                        foreach (JToken currentImageInfo in imageInfo)
                        {
                            imgUrlList.Add(currentImageInfo["imageUrl"].ToString());
                        }

                        if (imgUrlList.Count > 0)
                        {
                            var fileInfo = new DownloadedToonChapterFileInfo();
                            string imgName = imageNo.ToString("D5");
                            string imgSaveName = $"{imgName}.jpg";
                            string imgSavePath = $"{episodeSavePath}{imgSaveName}";

                            ToonHelpers.DrawAndSaveUnofficialWarningImage(languageName, teamName, imgSavePath);
                            fileInfo.FilePath = imgSavePath;
                            fileInfo.FilePathInArchive = imgSaveName;
                            downloadedImages.Add(fileInfo);

                            imageNo++;
                        }
                    }
                }

                string[] imgUrlArray = imgUrlList.ToArray();
                int totalImgCount = imgUrlArray.Length;

                if (totalImgCount != 0)
                {
                    totalImgCount += imageNo;
                    bool hasFailed = false;

                    foreach (string imgUrlRaw in imgUrlArray)
                    {
                        string imgUrl = imgUrlRaw;
                        ProcessInfo.Text = $"[ ({currentToon.ToonInfo.TitleNo}) {currentToon.ToonInfo.ToonTitleName} ] downloading image {imageNo} of chapter {episodeNo}!";

                        string imgName = imageNo.ToString("D5");
                        if (HighestQualityCB.Checked && currentToon.ToonInfo.ToonTranslationLanguageCode == "default")
                        {
                            imgUrl = Helpers.RemoveQueryStringByKey(imgUrl, "type");
                            imgName += "[HQ]";
                        }

                        var fileInfo = new DownloadedToonChapterFileInfo();
                        string imgExtension = Helpers.GetFileExtensionFromUrl(imgUrl);
                        string imgSaveName = $"{imgName}{imgExtension}";
                        string imgSavePath = $"{episodeSavePath}{imgSaveName}";

                        try
                        {
                            using (var request = new HttpRequestMessage(HttpMethod.Get, imgUrl))
                            {
                                request.Headers.Referrer = new Uri(currentToon.EpisodeList[i].Url);
                                using (var response = await HttpClient.SendAsync(request))
                                {
                                    response.EnsureSuccessStatusCode();
                                    using (var stream = await response.Content.ReadAsStreamAsync())
                                    using (var fileStream = new FileStream(imgSavePath, FileMode.Create, FileAccess.Write, FileShare.None))
                                    {
                                        await stream.CopyToAsync(fileStream);
                                    }
                                }
                            }
                        }
                        catch
                        {
                            imgSaveName = $"{imgName}_failed.png";
                            imgSavePath = $"{episodeSavePath}{imgSaveName}";
                            ToonHelpers.DrawAndSaveNotFoundImage(imageNo, imgSavePath);
                            hasFailed = true;
                        }

                        fileInfo.FilePath = imgSavePath;
                        fileInfo.FilePathInArchive = imgSaveName;
                        downloadedImages.Add(fileInfo);

                        try { ProgressBar.Value = i * 100 + (int)(imageNo / (float)totalImgCount * 100); } catch { }
                        imageNo++;
                    }

                    if (hasFailed) archiveSavePath += "_failed";

                    ToonHelpers.CreateBundledFile(SaveAs, archiveSavePath, downloadedImages);
                    if (chapterDirectoryWasCreated && ToonHelpers.IsBundle(SaveAs))
                    {
                        Directory.Delete(episodeSavePath, true);
                    }
                }
            }
        }

        public static string GetWebsiteNextPageUrl(HtmlAgilityPack.HtmlDocument htmlDoc)
        {
            var pageNodes = htmlDoc.DocumentNode.SelectNodes(Globals.episodeListPaginatorXPath);
            if (pageNodes == null) return "";

            bool bGetNextPage = false;
            foreach (var node in pageNodes)
            {
                if (node.Attributes["href"] != null)
                {
                    if (bGetNextPage)
                    {
                        return node.Attributes["href"].Value;
                    }

                    if (node.Attributes["href"].Value == "#")
                        bGetNextPage = true;
                }
            }
            return "";
        }

        #region visuals
        private void ExitBtn_Click(object sender, EventArgs e) { Application.Exit(); }
        private void ExitBtn_MouseEnter(object sender, EventArgs e) { ExitBtn.BackColor = Color.FromArgb(255, 20, 70, 34); }
        private void ExitBtn_MouseLeave(object sender, EventArgs e) { ExitBtn.BackColor = Color.FromArgb(255, 0, 30, 14); }

        private void MinimizeBtn_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void MinimizeBtn_MouseEnter(object sender, EventArgs e) { MinimizeBtn.BackColor = Color.FromArgb(255, 20, 70, 34); }
        private void MinimizeBtn_MouseLeave(object sender, EventArgs e) { MinimizeBtn.BackColor = Color.FromArgb(255, 0, 30, 14); }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofile = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder Selection"
            })
            {
                if (ofile.ShowDialog() == DialogResult.OK)
                {
                    SavepathTB.Text = Path.GetDirectoryName(ofile.FileName);
                }
            }
        }

        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {
            QueueGrid.Rows.Clear();
        }

        private void RemoveSelectedBtn_Click(object sender, EventArgs e)
        {
            if (QueueGrid.SelectedRows.Count > 0)
            {
                QueueGrid.Rows.RemoveAt(QueueGrid.SelectedRows[0].Index);
            }
        }

        private void DisableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableAllControls(c);
            }
            con.Enabled = false;
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RustingRobot/Kea#how-to-use");
        }

        private void SaveAsOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isMultipleImages = SaveAsOption.Text == "multiple images";
            ChapterFoldersCB.Enabled = isMultipleImages;
            ChapterFoldersCB.Checked = isMultipleImages;
        }

        private void EnableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                EnableAllControls(c);
            }
            con.Enabled = true;
        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        #endregion

        private void CollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                URLTextbox.Text = Clipboard.GetText();
            }
        }
    }
}
