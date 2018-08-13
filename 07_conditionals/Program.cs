using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            // SWITCH STATEMENT

            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();
​
            switch (inputName)
            {
                case "fred":
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    break;
                case "karl":
                    Console.WriteLine("Let's hang.");
                    break;
                case "john":
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default:
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    break;
            }





            //   IF   /   IF ELSE   /   ELSE     STATEMENTS

            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();
​
            if (feelingNumber == "5")
            {
                Console.WriteLine("That's great to hear!");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Good stuff!");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("Hope things get better!");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Oh. Sorry to hear that.");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("Dang. We hope your day gets better!");
            }
            else
            {
                Console.WriteLine("Sorry, we don't understand. Come back later.");
            }
            Console.ReadLine();



            // TERNARY

            int number = 10;
​​
            //Ternary Expression:
            string response = ((number == 7) ? "The number is 7." : "The number is not 7.");
            Console.WriteLine(response);





        }
    }
}
