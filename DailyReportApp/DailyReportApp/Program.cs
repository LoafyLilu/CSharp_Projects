using System;

namespace DailyReportApp
{
    class Program
    {
        static void Main()
        {
            // Starting the program, with introductory statements and asking the user their name
            // Their name is saved as a string, and written back as a greeting
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            // Asks the user to enter their course, stored as a string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            //Prompts the user to answer a boolean
            //Creates an if else statement based on conditions
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please write true or false");
            string needHelp = Console.ReadLine();
            bool wantHelp = Convert.ToBoolean(needHelp);

            //PProvides instructions to the user if help is needed
            if (wantHelp == true)
                Console.WriteLine("Please email your instructor and we will reach out to you");
            //Provides a motivational message to the user if help is not needed
            else
                Console.WriteLine("Great Job! Dont forget, we are here if you need us!");

            //Requests user input, and saves as a string
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
            string positiveExp = Console.ReadLine();

            //Requests user input, and saves as a string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedBack = Console.ReadLine();

            // Prompts the user to enter hours studied and saves them as an int
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Thank you for your answers! An instructor will respond to this shortly. Have a great day!");

            //Ends the program with a request to the user, and a pause ( rather than closing automatically ) 
            Console.WriteLine("Press any key to close the application");

            Console.ReadKey();

            







        }
    }
}
