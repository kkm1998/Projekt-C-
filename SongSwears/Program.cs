using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SongSwears
{
    class Program
    {
        static void Main(string[] args)
        {
            //var songAnalysis = new SongAnalysis("Kazik", "12 groszy");
            var tekst = "Programowanie jest w chuj fajne";
            var censor = new Censor();
            Console.WriteLine(censor.Fix(tekst));
            Console.ReadLine();
        }
    }

    internal class Censor
    {
        string[] badWords;
        public Censor()
        {
            var profanitiesfile = File.ReadAllText("profanities.txt");
            profanitiesfile = profanitiesfile.Replace("*", "");
            profanitiesfile = profanitiesfile.Replace("(", "");
            profanitiesfile = profanitiesfile.Replace(")", "");
            profanitiesfile = profanitiesfile.Replace("\"", "");
            badWords = profanitiesfile.Split(',');

        }

        internal string Fix(string tekst)
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
