using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kea.CommonFiles
{
	class Globals
	{
		//Contains constants & variables that are shared between all classes.
		public const ushort maxSingleImageHeight = 30000;

        // --- NEW PATHS – ANSWER KEYS ---
        public const string episodeListHtmlXPath = "//ul[@id='_listUl']";
        public const string episodeListItemHtmlXPath = "//ul[@id='_listUl']/li[contains(@class, '_episodeItem')]";
        public const string episodeListPaginatorXPath = "//div[contains(@class, 'paginate')]/a";

        public const string episodeImageHtmlXPath = "//body/div[@id='wrap']/div[@id='container']/div[@id='content']/div[@class='cont_box']/div[@class='viewer_lst']/div[@id='_imageList']/img";
		
		public const string naverWebtoonAPIBaseUrl = "https://global.apis.naver.com/lineWebtoon";

        //Brand-new 2026 User-Agent
        public const string spoofedUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/150.0.0.0 Safari/537.36";

    }
}
