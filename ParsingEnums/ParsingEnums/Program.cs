using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    //Creates the enum DaysOfTheWeek
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Starts a try catch block
            try
            {
                //Takes user input and parses the enumerated list for a match
                Console.WriteLine("Please enter the day of the week!");
                string userDay = Console.ReadLine();
                DaysOfTheWeek day;

                //if the input is found
                if (Enum.TryParse<DaysOfTheWeek>(userDay, out day))
                {
                    Console.WriteLine("Hooray! Its " + userDay);
                    Console.ReadLine();
                }
                //if the input is not found
                else
                {
                    throw new Exception();
                }

            }

            //tells the program what to do when input is not found
            catch (Exception)
            {
                Console.WriteLine("Uhh....thats not a day of the week!");
            }

            Console.ReadLine();

        }
    }
}
