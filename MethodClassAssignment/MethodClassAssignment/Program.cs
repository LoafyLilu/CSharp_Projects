using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Instanciates the class, and passes in the values of
                5, and 4 into the method AddThings
            */
            Stuff thing1 = new Stuff();
            thing1.AddThings(5, 4);

            /*
                creates another instance of the class, and passes in
                the parameter names into the method AddThings
            */

            Stuff thing2 = new Stuff();
            thing1.AddThings(a:4 , b:5);

            Console.ReadLine();

        }
    }
}
