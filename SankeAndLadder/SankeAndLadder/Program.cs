using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            int diceRoll;

            Random random = new Random();
            diceRoll = random.Next(1, 7);

            Console.WriteLine("starting point{0} and random number{1}:"+position,diceRoll);
        }
    }
}
