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

         // Comparison Operation

            // == Equality

            // != Inequality

            // < Less than

            // <= Less than or equal to

            // > Greater than

            // >= Greater than or equal to

            // && And

            // || Or


            // The default value is false

            bool isSad = false;
            bool isHappy = true;


            int value = 100 / 2;

            if (value == 50)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }




            // Gold Challenge

            // Create a program where the user has to guess what number the program is thinking of.
            // The user will enter in a number, then the program will hit different boolean logic and spit some data back 
            // to the user telling them whether they need to go higher or lower. In this challenge you can just pick the winning number.


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
