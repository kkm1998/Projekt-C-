using System;
using System.Collections.Generic;

namespace SongSwears
{
    public class SwearStats:Censor
    { 


        Dictionary<string, int> przeklenstwa = new Dictionary<string, int>();


        public void AddSwearsFrom(Song song)
        {
            foreach (var word in badWords)
            {
                var occurences = song.CountOccurences(word);
                if (occurences > 0)
                {
                    if (!przeklenstwa.ContainsKey(word))
                        przeklenstwa.Add(word, 0);
                    przeklenstwa[word] += occurences;
                }
            }
        }

        internal int FindCommonSwearsScore(SwearStats anotherStats)
        {
            int score = 0;
            foreach(var myWord in przeklenstwa)
            {
                if (anotherStats.przeklenstwa.ContainsKey(myWord.Key))
                    score++;
                else
                    score--;
            }
            return score;
        }

        internal void ShowSummary()
        {
            foreach (var item in przeklenstwa)
                Console.WriteLine(item.Key + " - " + item.Value);

        }
    }
}
