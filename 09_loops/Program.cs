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

            // WHILE loop

            int number = 0;

            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }
            Console.ReadLine();


            // FOR loop

            int number2 = 100;
​
            for (int i = 1; i <= number2; i++)
            {
                Console.WriteLine(i);
            }







        }
    }
}
