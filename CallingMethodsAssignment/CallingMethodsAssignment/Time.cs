using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    // Creates the class of Time
    public class Time
    {
        //Method to calculate the users age in months
        public int monthsOld(int userAge)
        {
            return userAge * 12;
        }

        //Method to calculate the users age in weeks
        public int weeksOld(int userAge)
        {
            return userAge * 52;
        }

        //Method to calculate the users age in days
        public int daysOld(int userAge)
        {
            return userAge * 365;
        }
    }

