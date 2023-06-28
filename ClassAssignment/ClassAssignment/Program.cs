using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This block creats an instance of the class Numbers, asks for user input, and converts
            the input to int data type. The variable is then passed into the MultiplyThings method
            from the class Numbers
            */
            Numbers num1 = new Numbers();
            Console.WriteLine("Please enter a number!");
            int userNum = Convert.ToInt32(Console.ReadLine());

            num1.MultiplyThings(userNum);
            Console.ReadLine();

            /*
            This block sets the default values of variables as 0, that will be replaced by
            the defined values listed in the function OutputThings
            */
            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;

            Numbers num2 = new Numbers();
            num2.OutputThings(out numOne, out numTwo, out numThree);
            Console.ReadLine();
            
            /*
            The next few blocks set the default variables value at 0, to be replaced with the 
            set values defined in the class method. A new instance is then created, for the method to be used
            on with the given parameters
            */

            int thing1 = 0;
            Numbers num3 = new Numbers();
            num3.OverloadThings(thing1);
            Console.ReadLine();

            decimal thing2 = 0;
            decimal thing3 = 0;
            Numbers num4 = new Numbers();
            num4.OverloadThings(thing2, thing3);
            Console.ReadLine();

            /*
            Sets the values of the static class within the main program, because
            a static class cannot be instanciated. This passes in the defined values into the
            place holders, and references them at the end of console.writeline
            */

            StaticStuff.name = "Charissa";
            StaticStuff.color = "Blue";
            StaticStuff.vehicle = "Honda Civic";

            Console.WriteLine("Heya! my name is {0}", StaticStuff.name);
            Console.WriteLine("and I drive a {0}", StaticStuff.color);
            Console.WriteLine("{0}", StaticStuff.vehicle);

            Console.ReadLine();

        }
    }
}
