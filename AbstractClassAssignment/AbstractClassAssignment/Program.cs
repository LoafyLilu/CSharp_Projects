using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Instanciates the Person class by creating an object of the Employee class
                Variables are assigned to the inherited properties, and the overridden method is ran
                on the emp1 object
            */
            Person emp1 = new Employee();
            emp1.firstName = "Sample";
            emp1.lastName = "Student";

            emp1.SayName();
            Console.ReadLine();

            
            
            
        }
    }
}
