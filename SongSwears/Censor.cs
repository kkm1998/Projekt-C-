using System.IO;
using System.Text.RegularExpressions;

namespace SongSwears
{
     public class Censor
    {
         protected string[] badWords;
        public Censor()
        {
            var profanitiesfile = File.ReadAllText("profanities.txt");
            profanitiesfile = profanitiesfile.Replace("*", "");
            profanitiesfile = profanitiesfile.Replace("(", "");
            profanitiesfile = profanitiesfile.Replace(")", "");
            profanitiesfile = profanitiesfile.Replace("\"", "");
            badWords = profanitiesfile.Split(',');

        }

         string Fix(string tekst)
        {
            foreach (var word in badWords)
            {
                tekst = ReplaceBadWord(tekst,word);
            }
            //Regular Expressions
            return tekst;
        }
        
        private string ReplaceBadWord(string tekst, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(tekst, pattern, "_________", RegexOptions.IgnoreCase);
            
        }
        
    }
}
