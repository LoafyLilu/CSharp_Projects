using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                This block will create a new object of the class Time, using
                the users input. It is converted from data type string to int,
                and used as the arguments for the appropriate method
            */

            Time time1 = new Time();
            Console.WriteLine("Hey! Want to see how old you -really- are?");
            Console.WriteLine("Please enter your age");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(time1.monthsOld(userAge));
            Console.WriteLine("Wow, thats a lot of months!");

            Console.WriteLine(time1.weeksOld(userAge));
            Console.WriteLine("Wow, thats a lot of weeks!");

            Console.WriteLine(time1.daysOld(userAge));
            Console.WriteLine("Wow, thats a lot of days!");

            Console.ReadLine();
        }
        

    }
}