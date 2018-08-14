using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_operators
{
    class Program
    {
        static void Main(string[] args)
        {

            // The first thing to know is that C# uses common math using the operators + - * /. 
            // Ones you should already know. For example, add the following code:

            Console.WriteLine(5 + 2);  //result = 7
            Console.WriteLine(10 - 6); //result = 4
            Console.WriteLine(2 * 3);  //result = 6
            Console.WriteLine(10 / 2); //result = 5

            // There is another common operator called the modulus operator - %. 
            // This is not a percentage, but the remainder when two numbers are divided. For example:
            
            Console.WriteLine(10 % 2); //result = 0 (10/2 = 5 w/ remainder of 0)
            Console.WriteLine(10 % 9); //result = 1 (10/9 = 1 w/ remainder of 1)
            Console.WriteLine(16 % 3); //result = 1 (16/3 = 5 w/ remainder of 1)
            Console.WriteLine(19 % 5); //result = 4 (19/5 = 3 w/ remainder of 4)

            // % can be used to easily determine if a number is even or odd, even numbers % 2 are always 0.

          

        }
    }
}
