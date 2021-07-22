using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
 ____________________________________________________________
| __        __         _                                     |
| \ \      / /   ___  | |   ___    ___    _ __ ___     ___   | 
|  \ \ /\ / /   / _ \ | |  / __|  / _ \  | '_ ` _ \   / _ \  |
|   \ V  V /   |  __/ | | | (__  | (_) | | | | | | | |  __/  |
|    \_/\_/     \___| |_|  \___|  \___/  |_| |_| |_|  \___|  |
|                                                            |
|                                                            |
|            You are playing Guess The Number!               |
|    You have 4 chances to guess the correct number.         |
|____________________________________________________________|");

           Console.WriteLine("");
            
            var random = new Random();
            int randomNumber = random.Next(1, 10);
            int numberOfGuesses = 4;
            int number = 0;
            bool gameOver = false;

            while (numberOfGuesses != 0)
            {
                Console.Write("Pick a number between 1 - 10: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number != randomNumber && numberOfGuesses >= 1)
                {
                    numberOfGuesses--;

                    Console.WriteLine("You guessed WRONG :(");
                    Console.WriteLine("You have {0} chances remaining", numberOfGuesses);
                    Console.WriteLine("");
                }
                else
                {
                    gameOver = true;
                    Console.WriteLine("You guessed CORRECT :)");
                    break;
                }

                
            }

            gameOver = true;
            
            if (gameOver == true)
            {
                Console.WriteLine(@"                                  
,---.                   ,---.                
|  _.,---.,-.-.,---.    |   |.    ,,---.,---.
|   |,---|| | ||---'    |   | \  / |---'|    
`---'`---^` ' '`---'    `---'  `'  `---'`    
                                             ");
            }

            Console.ReadKey();
        }
    }
}
