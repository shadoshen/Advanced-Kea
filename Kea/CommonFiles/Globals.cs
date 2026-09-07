
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Kea.CommonFiles
{
    class Globals
    {
        public const ushort maxSingleImageHeight = 30000;

        public const string episodeListHtmlXPath = "//ul[@id='_listUl']";
        public const string episodeListItemHtmlXPath = "//ul[@id='_listUl']/li[contains(@class, '_episodeItem')]";
        public const string episodeListPaginatorXPath = "//div[contains(@class, 'paginate')]/a";
        public const string episodeImageHtmlXPath = "//body/div[@id='wrap']/div[@id='container']/div[@id='content']/div[@class='cont_box']/div[@class='viewer_lst']/div[@id='_imageList']/img";
        public const string naverWebtoonAPIBaseUrl = "https://global.apis.naver.com/lineWebtoon";

        // Customizable Properties
        public static string ChromeUserAgent { get; set; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/152.0.0.0 Safari/537.36";
        public static string FirefoxUserAgent { get; set; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:155.0) Gecko/20100101 Firefox/155.0";
        public static bool UseFirefox { get; set; } = true;

        public static string SpoofedUserAgent => UseFirefox ? FirefoxUserAgent : ChromeUserAgent;

        private static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
        private const string JsonUrl = "https://raw.githubusercontent.com/jnrbsn/user-agents/main/user-agents.json";

        public static void LoadSettings()
        {
            if (!File.Exists(ConfigPath)) return;

            var lines = File.ReadAllLines(ConfigPath);
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { '=' }, 2);
                if (parts.Length != 2) continue;

                var key = parts[0].Trim();
                var value = parts[1].Trim();

                if (key == "ChromeUA") ChromeUserAgent = value;
                else if (key == "FirefoxUA") FirefoxUserAgent = value;
                else if (key == "UseFirefox") UseFirefox = bool.TryParse(value, out bool b) && b;
            }
        }

        public static void SaveSettings()
        {
            var lines = new[]
            {
                $"ChromeUA={ChromeUserAgent}",
                $"FirefoxUA={FirefoxUserAgent}",
                $"UseFirefox={UseFirefox}"
            };
            File.WriteAllLines(ConfigPath, lines);
        }

        public static async Task<bool> UpdateFromGitHubAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("KeaApp/1.0");
                    string json = await client.GetStringAsync(JsonUrl);

                    // Deserializing the JSON array using Newtonsoft.Json
                    var userAgents = JArray.Parse(json).Select(token => token.ToString()).ToList();

                    // 1. Filter only User-Agents for Windows 10/11 x64
                    var windowsUserAgents = userAgents.Where(ua =>
                        ua.Contains("Windows NT 10.0") &&
                        ua.Contains("Win64")
                    ).ToList();

                    // 2. Find the latest version of Chrome (excluding Edge, Opera, and mobile versions)
                    string newChrome = windowsUserAgents.LastOrDefault(ua =>
                        ua.Contains("Chrome/") &&
                        !ua.Contains("Edg/") &&
                        !ua.Contains("OPR/") &&
                        !ua.Contains("Android") &&
                        !ua.Contains("Mobile"));

                    // 3. Find the latest version of Firefox on Windows
                    string newFirefox = windowsUserAgents.LastOrDefault(ua =>
                        ua.Contains("Firefox/") &&
                        !ua.Contains("Android") &&
                        !ua.Contains("Mobile"));

                    if (newChrome != null || newFirefox != null)
                    {
                        if (newChrome != null) ChromeUserAgent = newChrome;
                        if (newFirefox != null) FirefoxUserAgent = newFirefox;

                        SaveSettings();
                        return true;
                    }
                }
            }
            catch
            {
                // Error Handling in Case of Connection Problems
            }
            return false;
        }
    }
}
