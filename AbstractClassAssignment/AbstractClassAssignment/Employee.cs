using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Creates the Employee class, based off the abstract Person class
    class Employee : Person
    {
        //Overrides the empty abstract method from the Person class
        public override void SayName()
        {
            /*
            Tells the program to print the message including the properties that will be
            substituted in on instanciation of the Employee class
            */
            Console.WriteLine("Hello there " + firstName + " " + lastName);
        }
    }
}
