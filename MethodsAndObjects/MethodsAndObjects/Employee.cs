using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //Allows the Employee Class to inherit variables from the superclass Person
    public class Employee : Person
    {
        //Adds the variable of data type int Id to the Employee Class only,
        // but does not set a value
        int Id;
    }
}
