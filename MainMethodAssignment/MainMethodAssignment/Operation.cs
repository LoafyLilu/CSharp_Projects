using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Operation
    {

        /* 
        This block creates the mathOperation method,
         overloading the method with 3 different data
        types. The int is returned as such, while the decimal and string
        are converted during the math operations
        */

        public int mathOperation(int userSalary)
        {
            return userSalary / 12;
        }

        public int mathOperation(decimal userHourly)
        {
            return Convert.ToInt32(userHourly * 40) * 52;
        }

        public int mathOperation(string userIncome)
        {
        return Convert.ToInt32(userIncome) * 10;
        }

    }

