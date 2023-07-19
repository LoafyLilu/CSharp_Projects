using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Employee
    {
        //Creates the Class Employee with 3 properties
        public int Id;
        public string FirstName;
        public string LastName;



        //Overloads the = operator
        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.Id.Equals(e2.Id))
                return true;
            else
                return false;


            
        }

        //Overloads the != operator
        public static bool operator !=(Employee e1, Employee e2)
        {
            if (e1.Id.Equals(e2.Id))
                return true;
            else
                return false;

        }
        

    }
}
