﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using system drawing to make changes to console colors
using System.Drawing;


namespace doWhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcomes the user to the app, and prompts them for input
            Console.WriteLine("Color Change App");
            Console.WriteLine("Please enter your favorite primary color, in lowercase only");

            //Creates a variable string based on user input
            // sets bool to true, in match case
            string bgColor = (Console.ReadLine());
            bool changeColor = true;


            /* Each of the following blocks withh set the background color to the users input, if it matches
            one of the listed case options. It then resets the color, and prompts the user again. If the
            user enters something other than the listed cases, it will return the default statement
            */

            do
            {
                switch (bgColor)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Here is something red! Have a great day!");
                        Console.ResetColor();
                        Console.WriteLine("Please enter your favorite primary color, in lowercase only");
                        bgColor = (Console.ReadLine());
                        break;

                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Here is something yellow! Have a great day!");
                        Console.ResetColor();
                        Console.WriteLine("Please enter your favorite primary color, in lowercase only");
                        bgColor = (Console.ReadLine());
                        break;

                    case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Here is something blue! Have a great day!");
                        Console.ResetColor();
                        Console.WriteLine("Please enter your favorite primary color, in lowercase only");
                        bgColor = (Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("This is not a primary color. Please enter red, blue, or yellow.");
                       bgColor = (Console.ReadLine());
                        break;


                }
            }

            while (changeColor);

            Console.ReadLine();
            
        }
    }
}
