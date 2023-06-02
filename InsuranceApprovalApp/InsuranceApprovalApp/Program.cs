using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApprovalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays an intro to the user, and asks them a question. The input is then converted from a string to an int
            Console.WriteLine("Welcome to the Insurance Approval App.\n Please answer the following questions\n");
            Console.WriteLine("What is your Age?");
            int userAge = int.Parse(Console.ReadLine());

            //Asks user a question, and converts the string answer to a boolean
            Console.WriteLine("Have you ever had a DUI?\n Please answer true or false");
            bool drunkDriver = Convert.ToBoolean(Console.ReadLine());
            
            //Asks user a question and then converts string to int
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = int.Parse(Console.ReadLine());

            //Creates if else statement, if all conditions are met then first message is displayed
            if ((speedTicket <= 3) && (drunkDriver == false) && (userAge > 15))
            {
                Console.WriteLine("Congradulations! You qualify for insurance with us!");
            }
            else
            {
            //Creates a message and displays it to the user if all conditions are -not- met
                Console.WriteLine("Sorry, but you do not qualify for insurance with us");
            }




        }
    }
}
