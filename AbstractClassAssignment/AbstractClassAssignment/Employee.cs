using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Creates the Employee class, based off the abstract Person class and the interface IQuittable
    class Employee : Person , IQuittable
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

        //implements the abstract method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"\n Did you know this is an example of utilizing an interface for inheriting multiple classes! Cool huh?");   
        }

    }
}
