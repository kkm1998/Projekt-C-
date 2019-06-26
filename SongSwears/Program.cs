using SearchingCurses;
using System;
using System.Collections.Generic;
using System.IO;
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
            eminemSwearStats.AddSong("When I'm Gone");
            eminemSwearStats.AddSong("Lose Yourself");
            eminemSwearStats.AddSong("Not Afraid");
            eminemSwearStats.AddSong("The Real Slim Shady");

            var twoPackStats = new RapperSwearStats("2Pac");
            twoPackStats.AddSong("Changes");
            twoPackStats.AddSong("Dear Mama");
            twoPackStats.AddSong("Hail Mary");
            twoPackStats.AddSong("California Love");
            twoPackStats.AddSong("Me Agaist the World");

            var snoopDogStats = new RapperSwearStats("SnoopDog");
            snoopDogStats.AddSong("Lay Low");
            snoopDogStats.AddSong("Vato");
            snoopDogStats.AddSong("Bitch Please");
            snoopDogStats.AddSong("Who Am I");
            snoopDogStats.AddSong("Dogg Dogg World");

            var FifCentStats = new RapperSwearStats("50 Cent");
            FifCentStats.AddSong("In Da Club");
            FifCentStats.AddSong("Candy Shop");
            FifCentStats.AddSong("21 Questions");
            FifCentStats.AddSong("Many Man");
            FifCentStats.AddSong("Wanksta");

            var WizKhaStats = new RapperSwearStats("Wiz Khalifa");
            WizKhaStats.AddSong("KK");
            WizKhaStats.AddSong("Black and Yellow");
            WizKhaStats.AddSong("Promises");
            WizKhaStats.AddSong("So High");
            WizKhaStats.AddSong("No Sleep");

            var LilWayneStats = new RapperSwearStats("Lil Wayne");
            LilWayneStats.AddSong("Uproar");
            LilWayneStats.AddSong("Mirror");
            LilWayneStats.AddSong("Forever");
            LilWayneStats.AddSong("Love Me");
            LilWayneStats.AddSong("Mona Lisa");

            var DrDreStats = new RapperSwearStats("Dr. Dre");
            DrDreStats.AddSong("Housewife");
            DrDreStats.AddSong("Kush");
            DrDreStats.AddSong("Let Me Ride");
            DrDreStats.AddSong("Zoom");
            DrDreStats.AddSong("I Need a Doctor");

            var rappers = new List<RapperSwearStats>();
            rappers.Add(LilWayneStats);
            rappers.Add(eminemSwearStats);
            rappers.Add(FifCentStats);
            rappers.Add(DrDreStats);
            rappers.Add(WizKhaStats);
            rappers.Add(twoPackStats);
            rappers.Add(snoopDogStats);


            Console.WriteLine("Podaj tekst piosenki");
            string s = "1";
            List<string> piesn = new List<string> { };
            while (!string.IsNullOrEmpty(s))
            {                
                s = Console.ReadLine();
                piesn.Add(s);
            }
            string piosenka = string.Join(",", piesn.ToArray());
            

           
            
            var unknowSong = new Song(piosenka);

            /*
          Console.WriteLine("Podaj autora");
          string y = Console.ReadLine();

          Console.WriteLine("Podaj tytuł");
          string x = Console.ReadLine();

          var unknowSong = new Song(y,x);*/
            Console.WriteLine("{0,60}", "Ranking");
            var tinder = new RaperTinder(rappers, unknowSong);
            
            Console.ReadKey();

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
