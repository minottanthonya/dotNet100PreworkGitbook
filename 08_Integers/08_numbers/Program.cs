using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's review the different number types in C#.
            //This covers them all

            int i = 0;

            short sh = 32767;

            byte by = 255;

            long l = 7;

            decimal p = 99.99999999999999999999999999;

            double d = 7.80000000000000;
	
            float f = 10.8f;

            decimal dd = 7.80m;

            int? ni = null;

            //Typically you will want to use doubles or decimals when dealing with money or numbers that need to be exact.
            //In the first WriteLine you can see how many decimal places a double will go out to.
            //In the second WriteLine we rounded our number to the second decimal place to make the percentage more readable to our user.

               decimal Bill = 54.23;
               decimal Tip = 12;
​
               decimal Percentage = Tip / Bill;
​
               Console.WriteLine(Percentage);
               Console.WriteLine(Math.Round(Percentage, 2));
               Console.ReadLine();
        }
    }
}
