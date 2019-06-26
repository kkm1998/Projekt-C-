using Newtonsoft.Json;
using SearchingCurses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace SongSwears
{
     public class Song
    {
        public string title;
        public string artist;
        public string lyrics;
        public List<string> result;

        public Song(string band, string songName)
        {
           // var browser = new WebClient();
            string url = "https://api.lyrics.ovh/v1/"+band+"/"+songName;
           var json = WebCache.GetOrDownload(url);
            var lyricsData = JsonConvert.DeserializeObject<LyricsovhResponse>(json);

            title = songName;
            artist = band;
            lyrics = lyricsData.lyrics;
            
        }
        public Song(string piosenka)
        {
            lyrics = piosenka;
        }

        public Song(List<string> result)
        {
            
            
        }

        public int CountOccurences(string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Matches(lyrics, pattern, RegexOptions.IgnoreCase).Count;
        }


    }
}