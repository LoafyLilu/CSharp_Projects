using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        /*
        Sets the variables for the class Person, but does
        not define a value
        */
        string FirstName;
        string LastName;

        public void SayName(string FirstName, string LastName)
        {
            //Tells the console to display the variable values of the class
            Console.WriteLine("Name : [" + FirstName + " " + LastName + "]");
        }
    }
}
