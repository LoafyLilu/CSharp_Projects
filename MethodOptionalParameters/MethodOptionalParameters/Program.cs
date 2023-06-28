using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                    The following block of code runs if both numbers are entered by the user.
                    The console parses through the user input to see if the input contains two values.
                    If so, the block completes.
                */

                MathOperation operation1 = new MathOperation();
                Console.WriteLine("Please enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick another number - this is optional");
                int num2;
                bool num1Result = Int32.TryParse(Console.ReadLine(), out num2);

                int result = operation1.AddNumber(num1, num2);

                Console.WriteLine(result);
                Console.ReadLine();
            }

            catch
            {
                /*
                    This block will run if the user input for num2 is left blank.
                    , passing in only the defined value of num1
                */
                MathOperation operation2 = new MathOperation();
                int num1;
                bool numberResult = Int32.TryParse(Console.ReadLine(), out num1);
                int result = operation2.AddNumber(num1);

                Console.WriteLine(result);

                Console.ReadLine();
            }


        }
    }
}
