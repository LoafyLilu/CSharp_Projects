using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{

    class Program
    {
        //creates the class human
        class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // default constructor
            public Human()
            {
                Name = "Person";
                Age = 0;
            }

            //constructor with one parameter
            public Human(string name) : this()
            {
                Name = name;
            }

            //constructor with two parameters
            public Human(string name, int age) : this(name)
            {
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            //creates an example of a const and displays it to the console
            const string greeting = "Hello there!!";

            Console.WriteLine("{0}", greeting);
            Console.ReadLine();

            //creates an example of a var object and displays it to the console. 
            var greeting2 = "How is it going?";
            Console.WriteLine("{0}", greeting2);
            Console.ReadLine();

            //creating a new object of the class using the chained constructors

            var human = new Human("Charissa", 37);
            Console.WriteLine("Hello there! my name is {0} , and I am {1} years old.", human.Name, human.Age);
            Console.ReadLine();
        }
    }
}
