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
            int option;
            Random random = new Random();

            while (position < 100)
            {
                diceRoll = random.Next(1, 7);
                Console.WriteLine("You rolled a " + diceRoll);
                option = random.Next(1, 4);

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

                if (position < 0)
                {
                    Console.WriteLine("You went below position 0. Restarting from position 0.");
                    position = 0;
                }
                else if (position > 100)
                {
                    Console.WriteLine("You went above position 100. Staying at position " + (position - diceRoll));
                    position -= diceRoll;
                }
                else
                {
                    Console.WriteLine("Your new position is " + position);
                }
            }

            Console.WriteLine("You won the game! You are at position 100");
            Console.ReadLine();

        }
    }
}
