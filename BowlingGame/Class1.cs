using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] game = new string[] {"1, 4, 4, 5, 6, 4, 5, 5, 10, 0, 0, 1, 7, 3, 6, 4, 10, 0, 2, 8, 6"};
            //string[] frame = game[].Split()
            char[] remove = new char[] { ',' };
            int[] game = { 1, 2, 10, 0, 4, 5 };
            int[] frames;
            var strike = frames[0] + frames[1] * 2;
            var score = 0;


            //int[] frame = game.;


            foreach (frames in game)
            {
                if (frames[0] == 10)
                {
                    score += 10;
                    frames++;
                    strike;
                }
            }
        }
    }
}
