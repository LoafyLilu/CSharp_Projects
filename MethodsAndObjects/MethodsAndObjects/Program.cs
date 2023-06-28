using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This block instanciates the class Employee, setting the values of
            the inherited class Person. The program then runs the method SayName
            on the subclass object and displays the values applied
            */

            Employee employee1 = new Employee();
            string FirstName = "Sample";
            string LastName = "Student";

            employee1.SayName(FirstName,LastName);
        }
    }
}
