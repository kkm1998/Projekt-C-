using System;
using System.Collections.Generic;

namespace SongSwears
{
    public class RaperTinder
    {
        private List<RapperSwearStats> rappers;
        private Song unknowSong;

        public RaperTinder(List<RapperSwearStats> rappers, Song unknowSong)
        {
            this.rappers = rappers;
            this.unknowSong = unknowSong;

            var songSwearStats = new SwearStats();
            songSwearStats.AddSwearsFrom(unknowSong);
            foreach(var rapper in rappers)
            {
                var score = rapper.FindCommonSwearsScore(songSwearStats);
                
                Console.WriteLine("                             "+rapper.name + "{0,50}"," " + score +" points.");


            }
            
        }
    }
}
