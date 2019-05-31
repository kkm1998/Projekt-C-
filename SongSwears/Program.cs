using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSwears
{
    class Program
    {
        static void Main(string[] args)
        {
            var eminemSwearStats = new SwearStats();
            var song = new Song("Eminem", "Star");
            eminemSwearStats.AddSwearsFrom(song);
            //var censor = new Censor();
            //Console.WriteLine(censor.Fix(song.lyrics));
            //Console.ReadLine();
        }
    }

     class SwearStats:Censor
    { 


        Dictionary<string, int> przeklenstwa = new Dictionary<string, int>();


        public void AddSwearsFrom(Song song)
        {
            foreach (var word in badWords)
            {
                var occurences = song.CountOccurences(word);
            }
        }
    }
}
