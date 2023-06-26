using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                This block instanciates a new object of the class with each operation
                The console converts the string data to the appropriate type, that are then passed into the methods on the Operation class file. The console then displays results of the object, its method, and the parameters passed in.
            */
            Operation operation1 = new Operation();
            Console.WriteLine("Please enter your yearly salary, ex 25000 , 42000 .");
            int userSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(operation1.mathOperation(userSalary));

            Console.ReadLine();
            Console.WriteLine("This is your average monthly income!");

            Operation operation2 = new Operation();
            Console.WriteLine("Please enter your pay rate, ex 15.00 , 20.50 ");
            decimal userPay = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(operation2.mathOperation(userPay));

            Console.ReadLine();
            Console.WriteLine("This is your yearly pay at 40 hrs a week");

            Operation operation3 = new Operation();
            Console.WriteLine("Please enter a number");
            string userIncome = Console.ReadLine();
            Console.WriteLine(operation3.mathOperation(userIncome));
            Console.WriteLine("This is your number, times ten!");
            Console.ReadLine();

        }
    }
}
