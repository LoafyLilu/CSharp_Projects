using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Assignment 1
                Creates a string array, then requests user input and saves
                it as a string. The foreach loop then iterates through the list, and adds the
                user input to the end of the string. it then prints each appended iteration
            */

            //string[] fruitArray = new string[] { "Apples", "Oranges", "Cherries" };
            //Console.WriteLine("Do you like sweet or sour fruit?");
            //string favFlavor = Console.ReadLine();


            //foreach (string fruit in fruitArray)
            //{
            //    string fruitFlavors = favFlavor + " " + fruit;
            //    Console.WriteLine(fruitFlavors);
            //}
            //Console.ReadLine();

            /*  Assignment 2
                creating an infinite loop under the condition of true.
                Each iteration of the loop is printed to the console, taking that
                iteration and adding one to it. Until the if condition is met,
                and breaks the loop 
            */

            //int i = 0;

            //while (true)
            //{
            //    Console.WriteLine("i = {0}", i, i++);
            //    if (i > 10)
            //        break;

            //}
            //Console.ReadLine();

            /* Assignment 3
                Creating a loop determining wether or not to continue iterating the loop, with a < operator, then <= operator
            */

            //int n = 10;

            //while (true)
            //{
            //    Console.WriteLine("n = {0}", n, n--);

            //    if (n < 5)
            //        break;
            //}

            //int x = 10;

            //while (true)
            //{
            //    Console.WriteLine("x = {0}", x, x--);

            //    if (x <= 5)
            //        break;
            //}

            /*  Assignment 4
                Create a list of strings where each item is unique. Then requests user input to search for in the list. Creates a loop that iterates through the list and then displays the index of the list item that matches the search. Also creates a message for the user if their input is not found on the list. The iteration then ends when a match is found or if the user input is not found
            */

            //string[] sailors = { "moon", "mercury", "mars", "jupiter", "venus" };

            //Console.WriteLine("Please enter the name of a planet!");
            //string planet = Console.ReadLine();
            //int index = Array.IndexOf(sailors, planet);
            //bool hasplanet = sailors.Contains(planet);


            //if (hasplanet == true)
            //{
            //    Console.WriteLine("The index of your entry " + planet + " is " + index);
            //}

            //else
            //{
            //    Console.WriteLine("Your entry was not found. Sorry!");
            //}

            /*  Assignment 5
                Creating a list of strings that has two idential strings within. Asks the user for text to earch in the list.
                Creates a loop taht iterates through the list and displays the matching indecies for the entries. There is also a message displayed
                
            */

            //Console.WriteLine("Please enter your favorite type of pet!");
            //string favPet = Console.ReadLine();
            //List<string> coolPets = new List<string>();
            //coolPets.Add("dog");
            //coolPets.Add("cat");
            //coolPets.Add("bird");
            //coolPets.Add("fish");
            //coolPets.Add("ferret");
            //coolPets.Add("cat");


            //if (coolPets.Contains(favPet))
            //{
            //    for (int index = 0; index < coolPets.Count; index++)
            //    {
            //        if (coolPets[index] == favPet)
            //            Console.WriteLine("Great! Your favorite pet appears at index: " + index + "\n");
            //    }

            //}
            //else { Console.WriteLine("That pet type is not on our list. Too bad..."); }

            /*
                Assignment 6
                ccreates an initial list, and an empty list for future duplicate
                strings. A foreach loop is run, to see if the empty list contains the variable
                string. If it does, the item is a duplicate. if not, the item is stated as unique,
                and then  added to the duplicate list

            */

            List<string> colors = new List<string>()
            {
                "red",
                "blue",
                "green",
                "purple",
                "pink",
                "purple"
            };

            List<string> duplicates = new List<string>();
            
            foreach (var c in colors)
            {
                if (duplicates.Contains(c))
                {
                    Console.WriteLine(c + " - " + "This is a duplicate color!");
                }

                else
                {
                    Console.WriteLine(c + " - This is a unique color!");
                    duplicates.Add(c);
                }
            }
            Console.ReadLine();


        }
    }
}
