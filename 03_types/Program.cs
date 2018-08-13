using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            decimal accountBalance = 80000.30m;
            Console.WriteLine(accountBalance);

            int bYear = Int32.Parse("1976");
            Console.WriteLine("I was born in {0}.", bYear);

        }
    }
}
