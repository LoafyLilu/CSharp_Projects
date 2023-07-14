using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Creates the abstract class person, and its properties
    public abstract class Person
    {
        // 
        public string firstName;
        public string lastName;

        //Creates the abstract method
        public abstract void SayName();
        
    }
}
