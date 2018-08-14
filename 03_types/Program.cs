using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_types
{
    //The Basic Types within c#

        // int - 20 - whole number
        // A whole number with a size of 32 bits and range from -2,147,483,648 to 2,147,483,647.

        // float - 1.5f - 32bit or non whole number, up to 7 digits. 
        // Floating point integer, must put f explicit conversion afterwards.

        // double - 1.500000 - 64bit, up to 15-16 digits. 

        // decimal - 8.333333333333333333m - 128 bit, up to 28-29 digits, more precise than double or float, but also more costly. 
        // Mainly used for financial situations. 
        // **Without the suffix m, the number is treated as a double and generates a compiler error.**

        // bool - true, flase - standard boolean. 

        // string - "Hello World" - standard string. 

    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            decimal accountBalance = 80000.30m;
            Console.WriteLine(accountBalance);

            //Bronze Challenge
           
            // Create a list of value types: int, string, bool, float, double, decimal.
            // Do two examples for each type.
            // One is a declaration only.
            // The other is a declaration with initializer.
            // Print some of the values in the console.
            
            int lottoNumber;
            int yearGraduatedHighSchool = 1994;
​
            string fbPost;
            string reTweet = "Yes, I'll retweet that.";
​
            bool isMarried;
            bool isHappy = true;
​
            decimal studentLoanAmount;
            decimal bankAccount = 100.0M;
​
            float amountOfSnow;
            float temperature = 57.5f;
​
            double latitude;
            double oneThird = 3.33333333d;
​
            fbPost = "The Patriots are terrible!";
​
            Console.WriteLine(fbPost);
            Console.WriteLine(temperature);
            Console.WriteLine(oneThird);


            //Silver Challenge

            // Use those types to concatenate a string, any string will do.
            // Hint: The + operator can be used with strings.

            string fbPost;
            string reTweet = "Yes, I'll retweet that.";
            fbPost = "The Patriots are terrible!";
​
            Console.WriteLine(fbPost + " " + reTweet);
            
            //Gold Challenge

            //Declare the year you were born as a single string concatenated from several variables.

            int bYear = Int32.Parse("1976");
            Console.WriteLine("I was born in {0}.", bYear);

        }
    }
}


// Use the above table to try answering the following question:

  //  What is the best type for each of these items?

     // int = 23 

     // decimal = $3.33

     // double =  15.25456

     // int = -3500

    //  string = Hi!