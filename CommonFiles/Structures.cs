using System;

namespace Kea.CommonFiles
{
    public class DownloadedToonChapterFileInfo
    {
        public string FilePath { get; set; }
        public string FilePathInArchive { get; set; }
    }

    public class EpisodeListEntry
    {
        public string EpisodeSequence { get; set; }
        public int EpisodeNo { get; set; }
        public string EpisodeTitle { get; set; }
        public string Url { get; set; }
    }

    public class ToonListEntryInfo
    {
        public int TitleNo { get; set; }
        public string ToonTitleName { get; set; }

        public string ToonTranslationLanguageCode { get; set; }
        public string ToonTranslationTeamVersion { get; set; }

        public string StartDownloadAtEpisode { get; set; }
        public string StopDownloadAtEpisode { get; set; }
    }

    public class ToonListEntry
    {
        public ToonListEntryInfo ToonInfo { get; set; } = new ToonListEntryInfo();
        public EpisodeListEntry[] EpisodeList { get; set; } = Array.Empty<EpisodeListEntry>();
    }
}
