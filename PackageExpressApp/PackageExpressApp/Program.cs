using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The following block starts the program and requests the user to enter all pertinent information.
            As each line is read, it is also converted to int data type.
            */

            Console.WriteLine("Hey there! Welcome to Packages Express!\n Please follow the instructions below");

            Console.WriteLine("Please enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pleaes enter the package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            
            /* 
            This block utilizes the user input to create the variables needed to use within the if/else if/else block.
            It also converts an int into the decimal data type, and then to a string to be returned back to the user
            */

            int packageDimensions = packageWidth + packageHeight + packageLength;
            int tempCost = packageWidth * packageHeight * packageLength * packageWeight;
            int initialCost = tempCost / 100;
            decimal totalCost = Convert.ToDecimal(initialCost);
            string showTotal = totalCost.ToString("C");


            if (packageWeight > 50)
            {
                Console.WriteLine("The package is too heavy to be shipped via Package Express.");
            }

            else if (packageDimensions > 50)
            {
                Console.WriteLine("The package is too big to be shipped via Package Express");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is" + showTotal + " \n Thank you!");
            }

            Console.WriteLine("Thank you for shipping with Package Express! Please press enter to exit...!");

            //prompts the user to press any key to end the program
            Console.ReadKey();


            
            

            




        }
    }
}
