using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Numbers
    {
        /*
        Creates a method and declares the datatype and varible to be passed into the function.
        the int userNum is defined in the main program
        */

        public void MultiplyThings(int userNum)
        {
            Console.WriteLine((userNum / 2));
        }

        /*
        Creates the method and declares the data type and values of the variables that will be passed
        in to the method in the main program
        */

        public void OutputThings(out int numOne, out int numTwo, out int numThree )
        {
            numOne = 42;
            numTwo = 62;
            numThree = 84;

            Console.WriteLine($"{numOne} {numTwo} {numThree}");
        }

        /*
            The next few blocks are examples of overloading a method, with different data types
            and functions
        */
        public void OverloadThings(int thing1)
        {
            thing1 = 42;
            Console.WriteLine(thing1);
        }

        public void OverloadThings(decimal thing2, decimal thing3)
        {
            thing2 = 4.3m;
            thing3 = 2.5m;

            Console.WriteLine((thing2 + thing3));
        }
    }
}
