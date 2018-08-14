using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // WHILE LOOP

            // While loops execute a block of code as long as the condition you give it is true.
            // Once the condition is false, it will stop. Below is an example:
            
            int number = 0;

            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }
            Console.ReadLine();


            // FOR LOOP

            int number2 = 100;
​
            for (int i = 1; i <= number2; i++)
            {
                Console.WriteLine(i);
            }

            // Bronze Challenge

            // Create a for loop that prints the numbers 500 through 525.
          
            for (int y = 500; y <= 525; y++)
            {
                Console.WriteLine(y);
            }

            // Silver Challenge

            // Create a for loop that prints the numbers from 0-100 by 5's

            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }

            // Gold Challenge

            // Create a for loop that prints the numbers 1-100 to the console. 
            // If the # is divisible by 3, print Fizz instead of the number, if it's divisible by 5, print Buzz, 
            // if it's divisible by both 3 and 5, print FizzBuzz.

            for (int g = 1; g <= 100; g++ )
            {
                if (g % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (g % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (g % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(g);
                }
            }
        }
    }
}
