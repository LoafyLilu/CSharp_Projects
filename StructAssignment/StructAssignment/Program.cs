using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciates an object of Number and assigns a value
            Number number1 = new Number();
            number1.Amount = 10.5;

            //prints the value of number1 to the console
            Console.WriteLine(number1.Amount);
            Console.ReadLine();

            //Instanciates additional struct objects and displays their values

            Number number2 = new Number();
            Number number3 = number2;
            number2.Amount = 20.4;
            number3.Amount = 15.6;

            Console.WriteLine(number2.Amount);
            Console.ReadLine();

            Console.WriteLine(number3.Amount);
            Console.ReadLine();
            


        }
    }
}
