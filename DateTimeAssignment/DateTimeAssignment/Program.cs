using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an object of DateTime called rightMeow and assigns its value (DateTime.Now)
            //Then prints to the console
            DateTime rightMeow = DateTime.Now;
            Console.WriteLine(rightMeow);
            Console.WriteLine("Its exactly the time printed above, right MEOW!");

            //Takes user input, converts and saves as an int
            //Creates an object of DateTime to contain the results of adding user hours to rightMeow
            Console.WriteLine("Please enter a number");
            int userHours = Convert.ToInt32(Console.ReadLine());
            DateTime laterOn = rightMeow.AddHours(userHours);

            //Writes the results to the console
            Console.WriteLine("If we were to time travel into the future " + userHours+ " hours, it would be exactly.....");
            Console.WriteLine(laterOn);
            Console.ReadLine();
        
        }
    }
}
