using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                The following block creates two instances of the Employee class with their assigned properties. It then runs the overloaded operator method on the Id property, comparing the two for equality and prints a unique message to the user
                based on the bool results
            */

            Employee e1 = new Employee();
            e1.Id = 1;
            e1.FirstName = "Charissa";
            e1.LastName = "Day";

            Employee e2 = new Employee();
            e2.Id = 1;
            e2.FirstName = "Gabe";
            e2.LastName = "Parker";

            Console.WriteLine(e1.Id.Equals(e2.Id) ? "Ooops! These employees have the same ID!" : "Great! Both employees have unique IDs!");

            Console.ReadLine();
            


            

            

        }
    }
}
