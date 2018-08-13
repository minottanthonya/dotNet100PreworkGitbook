using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string wholeName = "Douglas Crockford";

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
            Console.WriteLine(first + " " + second);

            string firstName = "Jenn";
            string lastName = "Wilson";
            // Composite Formatting
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);
            // String Interpolation
            Console.WriteLine($"Her name is {firstName} {lastName}");



        }
    }
}
