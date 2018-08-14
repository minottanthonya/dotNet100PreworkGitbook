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

        }
    }
}
