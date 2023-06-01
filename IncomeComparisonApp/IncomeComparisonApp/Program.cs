using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
This small app was created to provide a boolean answer to a comparison of hour and pay rate data for two anonymous employees.

Note - This is a small assignment, and has much room for improvement.
Further maximizing its effeciency, other data types can be used for both pay data and hours worked ( decimal and timespan, respectively ).
*/

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");

            // Each section displays a message to the user, and converts their string input to an int,
            // saving it as a variable
            Console.WriteLine("Person 1, Please enter your Hourly Pay");
            int p1Pay = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 1, Please enter your Hours worked per Week");
            int p1Hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 2, Please enter your Hourly Pay");
            int p2Pay = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 2, Please enter your Hours worked per Week");
            int p2Hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Does Person 1 make more money than Person 2?");

            //Using boolean comparison to int variables
            //User must press any key to end the program
            Console.WriteLine(p1Pay > p2Pay);

            Console.ReadKey();
                






        }
    }

}