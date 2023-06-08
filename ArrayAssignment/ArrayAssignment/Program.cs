using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
            //Creating the initall string list, and entries
            List<string> stringList = new List<string>();
            stringList.Add("Eeny");
            stringList.Add("Meeny");
            stringList.Add("Miny");
            stringList.Add("Mo");
            
            //Asks user for input, then converts and saves string to int
            Console.WriteLine("Please enter a number");
            int userNum =  Convert.ToInt32(Console.ReadLine());
            

        //If the user num matches an available index console will write its entry
        if ( userNum <= 3)
        {
            Console.WriteLine(stringList[userNum]);
            Console.ReadLine();
        }

        //Otherwise, a message is displayed to the user
        else
        {
            Console.WriteLine("Sorry, that index does not exist.");
            Console.ReadLine();
        }

            //Creates a one dimensional array of numbers, and prompts the user to enter a number
            int[] numArray = new int[]{ 2, 4, 6, 8, 10 };
            Console.WriteLine("Please choose a number, 1 - 4");

            //saves user input and converts string to int
            int userArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numArray[userArray]);
            Console.ReadLine();

        //Creates a one dimensional array of strings, and prompts the user to enter a number
            string[] stringArray = new string[] { "Hi", "There", "Buddy" };
            Console.WriteLine("Please enter 0, 1 or 2");

        //Converts string to int, and writes the index value of user number in string array
            int buddyArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[buddyArray]);
            Console.ReadLine();
            




        



        }
    }

