using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_booleans
{
    class Program
    {
        static void Main(string[] args)
        {

            // The default value is false

            bool isSad = false;
            bool isHappy = true;

            float value = 101f / 2f;

            if (value == 50f)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }




            // GUESSING GAME LOGIC


            Console.WriteLine("Can you guess what number I am thinking of? It is between 1-20");

            int guessNumber = Convert.ToInt16(Console.ReadLine());

            if (guessNumber <= 7 && guessNumber >= 1)
            {
                Console.WriteLine("You need to go much higher!");
            }
            else if (guessNumber <= 14 && guessNumber > 7)
            {
                Console.WriteLine("Little bit higher!");
            }
            else if (guessNumber == 15)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
            }
            else if (guessNumber >= 16 && guessNumber <= 20)
            {
                Console.WriteLine("Oops, little bit lower");
            }
            else
            {
                Console.WriteLine("Did you read the instructions?");
            }

            Console.ReadLine();





        }
    }
}
