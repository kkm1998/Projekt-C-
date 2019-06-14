using SearchingCurses;
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
            
            var eminemSwearStats = new RapperSwearStats("Eminem");
            eminemSwearStats.AddSong("Stan");
            eminemSwearStats.AddSong("Rap God");
            eminemSwearStats.AddSong("Lose Yourself");
            //var song = new Song("Eminem", "Stan");
            //eminemSwearStats.AddSwearsFrom(song);
            var twoPackStats = new RapperSwearStats("2Pac");
            twoPackStats.AddSong("Changes");
            twoPackStats.AddSong("Dear Mama");
            twoPackStats.AddSong("Hail Mary");
            var rappers = new List<RapperSwearStats>();
            rappers.Add(eminemSwearStats);
            rappers.Add(twoPackStats);
            

            //var monsterSwearStats = new SwearStats();
            var unknowSong = new Song("Eminem", "Monster");
            var tinder = new RaperTinder(rappers, unknowSong);
            //monsterSwearStats.AddSwearsFrom(monster);
           // monsterSwearStats.FindCommonSwearsScore(eminemSwearStats);
            //var censor = new Censor();
            //Console.WriteLine(censor.Fix(song.lyrics));
            //eminemSwearStats.ShowSummary();
            Console.ReadLine();
    /*
            Console.WriteLine(WebCache.GetOrDownload("https://wtfismyip.com/text"));
                Console.ReadKey();
*/
        }

    }

    public class RapperSwearStats: SwearStats
    {
        public string name;
        public RapperSwearStats(string name)
        {
            this.name = name;
        }
        public void AddSong(string title)
        {
            var song = new Song(name,title);
            AddSwearsFrom(song);
        }
    }
}
