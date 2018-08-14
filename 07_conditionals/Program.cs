﻿using System;
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

            //   If, Else If, and Else Statements

            // In the previous module on booleans, we got a brief introduction to some if statements.
            // if statements check to see if a condition is true or false. We also gave a challenge in that module that 
            // would require you to use the else & if else keywords. Let's add some code that will allow us to write else if statements:

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

            //MULTIPLE IF STATEMENTS

            // If you have multiple if statements within a branch, your program will check all those if statements
            // even if a previous one resulted in true. Not a bad thing, but handy to know especially when you get into 
            // the speed of your application.

            bool isOn = true;
            bool isHot = false;
​
            if (isOn)
            {
                Console.WriteLine("The light is on, it's bright.");
            }
​
            if (isOn == true)
            {
                Console.WriteLine("The light is on.");
            }
​
            if (isOn && isHot)
            {
                Console.WriteLine("lights on and it's hot");
            }
​
            if (isOn || isHot)
            {
                Console.WriteLine("lights on or it is hot");
            }
​
            if (!isHot)
            {
                Console.WriteLine("it is not hot");
            }

            // TERNARY

            // Ternary Expressions are simply a different way to write if statements. 
            // They provide less lines of code, reduce nesting, and therefore help your program run faster and more efficiently.

            int number = 10;
​
            //If Else Statement
            if (number == 7)
                Console.WriteLine("The number is 7.");
            else
                Console.WriteLine("The number is not 7.");
​
            //Ternary Expression:
            string response = ((number == 7) ? "The number is 7." : "The number is not 7.");
            Console.WriteLine(response);

        }
    }
}
