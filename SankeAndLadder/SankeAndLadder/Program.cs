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
            //int option = 0

            Random random = new Random();  //Creating object random
            diceRoll = random.Next(1, 7); // //Using random method

            Console.WriteLine("starting point{0} and random number{1}:"+position,diceRoll);

            Random random1 = new Random(); //Creating object random
            int option = random1.Next(1, 4);  //Using random method

            switch (option)
            {
                case 1:
                    Console.WriteLine("No Play. You stay in the same position.");
                    break;
                case 2:
                    Console.WriteLine("Ladder! You move ahead by " + diceRoll + " positions.");
                    position += diceRoll;
                    break;
                case 3:
                    Console.WriteLine("Snake! You move back by " + diceRoll + " positions.");
                    position -= diceRoll;
                    break;
            }
        }
    }
}
