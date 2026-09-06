using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Kea.CommonFiles
{
    internal class ToonHelpers
    {
        public static void CreateBundledFile(string saveAs, string episodeSavePath, List<DownloadedToonChapterFileInfo> downloadedFiles)
        {
            DownloadedToonChapterFileInfo[] files = downloadedFiles.ToArray();
            string bundleExtension = GetBundleExtension(saveAs);

            if (saveAs == "PDF file")
            {
                Document doc = new Document();
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream($"{episodeSavePath}{bundleExtension}", FileMode.Create));
                    doc.Open();
                    for (int j = 0; j < files.Length; j++)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(files[j].FilePath);
                        img.SetAbsolutePosition(0, 0);
                        doc.SetPageSize(new iTextSharp.text.Rectangle(img.Width, img.Height));
                        doc.NewPage();
                        doc.Add(img);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating the PDF : {ex.Message}");
                }
                finally
                {
                    doc.Close();
                }
            }
            else if (saveAs == "one image (may be lower in quality)")
            {
                Bitmap[] images = new Bitmap[files.Length];
                int finalHeight = 0;
                for (int j = 0; j < images.Length; j++)
                {
                    images[j] = new Bitmap(files[j].FilePath);
                    finalHeight += images[j].Height;
                }

                using (Bitmap bm = new Bitmap(images[0].Width, finalHeight))
                {
                    int pointerHeight = 0;
                    using (Graphics g = Graphics.FromImage(bm))
                    {
                        for (int k = 0; k < images.Length; k++)
                        {
                            g.DrawImage(images[k], 0, pointerHeight);
                            pointerHeight += images[k].Height;
                        }
                    }

                    if (finalHeight > Globals.maxSingleImageHeight)
                    {
                        Bitmap resizedImage = Helpers.ResizeImage(bm, (int)(images[0].Width * (1.0 - (float)(finalHeight - Globals.maxSingleImageHeight) / finalHeight)), Globals.maxSingleImageHeight);
                        resizedImage.Save($"{episodeSavePath}{bundleExtension}");
                    }
                    else
                    {
                        bm.Save($"{episodeSavePath}{bundleExtension}");
                    }
                }

                foreach (Bitmap image in images)
                {
                    image.Dispose();
                }
            }
            else if (saveAs == "CBZ file")
            {
                using (FileStream zipToOpen = new FileStream($"{episodeSavePath}{bundleExtension}", FileMode.Create))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        for (int j = 0; j < files.Length; j++)
                        {
                            archive.CreateEntryFromFile(files[j].FilePath, files[j].FilePathInArchive, CompressionLevel.Optimal);
                        }
                    }
                }
            }
        }

        public static bool IsBundle(string saveAs)
        {
            return saveAs == "PDF file" || saveAs == "one image (may be lower in quality)" || saveAs == "CBZ file";
        }

        public static string GetBundleExtension(string saveAs)
        {
            if (saveAs == "PDF file")
                return ".pdf";
            if (saveAs == "one image (may be lower in quality)")
                return ".png";
            if (saveAs == "CBZ file")
                return ".cbz";

            return "";
        }

        public static string GetToonSavePath(ToonListEntryInfo toonInfo)
        {
            string languageCode = toonInfo.ToonTranslationLanguageCode;
            if (languageCode == "default")
                languageCode = "";

            if (toonInfo.ToonTranslationLanguageCode != "default" && toonInfo.ToonTranslationTeamVersion != "default")
                languageCode += $"-{toonInfo.ToonTranslationTeamVersion}";

            if (!Helpers.IsStringEmptyNullOrWhiteSpace(languageCode))
                languageCode = $"[{languageCode}]";

            string sanitizedTitleName = Helpers.SanitizeStringForFilePath(toonInfo.ToonTitleName);
            // Ligne 137 corrigée : Suppression de .ToString("D6") explicite dans l'interpolation
            return $"{languageCode}{sanitizedTitleName}[{toonInfo.TitleNo:D6}]";
        }

        public static string GetToonEpisodeSavePath(EpisodeListEntry episodeInfo, string suffix)
        {
            return $"[{episodeInfo.EpisodeSequence}]({episodeInfo.EpisodeNo}) {episodeInfo.EpisodeTitle}{suffix}";
        }

        public static void DrawAndSaveNotFoundImage(int imageNumber, string savePath)
        {
            GraphicsPath gp = new GraphicsPath();

            Bitmap bm = new Bitmap(400, 200);
            int radius = 25;
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(5, 5, 390, 190);
            System.Drawing.Rectangle arc = new System.Drawing.Rectangle(bounds.Location, size);

            gp.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            gp.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            gp.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            gp.AddArc(arc, 90, 90);
            gp.CloseFigure();

            LinearGradientBrush brush = new LinearGradientBrush(new Point(5, 5), new Point(395, 195), Color.OrangeRed, Color.DarkRed);
            LinearGradientBrush brush2 = new LinearGradientBrush(new Point(0, 0), new Point(400, 200), Color.Black, Color.White);

            using (Graphics g = Graphics.FromImage(bm))
            {
                g.DrawPath(new Pen(Color.Black, 5), gp);
                g.FillRectangle(brush2, new System.Drawing.Rectangle(0, 0, 400, 200));
                g.FillPath(brush, gp);
                // Ligne 182 corrigée : Suppression de .ToString("D5") explicite dans l'interpolation
                g.DrawString($"Image {imageNumber:D5} not found!", new System.Drawing.Font(FontFamily.GenericSansSerif, 35, FontStyle.Bold | FontStyle.Strikeout), Brushes.White,
                    new System.Drawing.Rectangle(5, 5, 390, 190),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                g.Save();
            }
            bm.Save(savePath);
        }

        public static void DrawAndSaveUnofficialWarningImage(string languageName, string teamName, string savePath)
        {
            if (!Helpers.IsStringEmptyNullOrWhiteSpace(teamName))
                teamName = $"- {teamName}";

            Bitmap bm = new Bitmap(400, 200);
            System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(50, 10, 300, 40);
            System.Drawing.Rectangle textBounds = new System.Drawing.Rectangle(50, 13, 300, 40);
            System.Drawing.Rectangle textBounds2 = new System.Drawing.Rectangle(0, 60, 400, 130);
            GraphicsPath gp = Helpers.MakeRoundedRect(bounds, 20, 20, true, true, true, true);

            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.Black);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawPath(new Pen(Color.LightGreen, 5), gp);
                g.DrawString("Unofficial", new System.Drawing.Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold), Brushes.LightGreen,
                    textBounds,
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                g.DrawString($"This is translated in {languageName} by WEBTOON fans{teamName}", new System.Drawing.Font(FontFamily.GenericSansSerif, 21, FontStyle.Bold), Brushes.White,
                    textBounds2,
                    new StringFormat { Alignment = StringAlignment.Center });
            }
            bm.Save(savePath);
        }
    }
}