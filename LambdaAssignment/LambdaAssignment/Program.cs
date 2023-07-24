using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a list of Employees and assigns values to each property
            List<Employee> emps = new List<Employee>()
            {
                new Employee { Id = 1, firstName = "Joe", lastName = "Schmoe"},
                new Employee { Id = 2, firstName = "Amy", lastName = "Crause"},
                new Employee { Id = 3, firstName = "Bob", lastName = "Billy"},
                new Employee { Id = 4, firstName = "Kelly", lastName = "Kaput"},
                new Employee { Id = 5, firstName = "Joe", lastName = "Jackson"},
                new Employee { Id = 6, firstName = "Kendrick", lastName = "Burke"},
                new Employee { Id = 7, firstName = "Emily", lastName = "Blair"},
                new Employee { Id = 8, firstName = "Martin", lastName = "Ehnaun"},
                new Employee { Id = 9, firstName = "Jasen", lastName = "Kottke"},
                new Employee { Id = 10, firstName = "Joe", lastName = "Hobo"},
            };

            //Creates a for each loop to go through each employee and check their first name
            //then adds item to list if conditions are met
            List<Employee> severalJoes = new List<Employee>();
            foreach (Employee e in emps)
            {
                if (e.firstName == "Joe")
                {
                    severalJoes.Add(e);
                }
                else
                {
                    continue;
                }
            }

            severalJoes.ForEach(Console.WriteLine);



            //Creates an list of employees that meet the lambda function conditions
            List<Employee> lotsaJoe = emps.Where(x => x.firstName == "Joe").ToList();

            //Creates a foreach loop to iterate over each result on the list and display the results
            foreach (Employee e in lotsaJoe)
            {
                Console.WriteLine(e.firstName + " " + e.lastName);
            }
            Console.WriteLine("Woah! Thats a lotta Joes!");
            Console.ReadLine();

            //Creates an enumerable list of employees that meet the lamba function conditions
            List<Employee> newEmployees = emps.Where(x => x.Id > 5).ToList();


            //Creates a foreach loop to iterate over each result on the list and display the results
            foreach (Employee n in newEmployees)
            {
                Console.WriteLine(n.Id + " - This employee has an ID greater than 5!");
                Console.ReadLine();

            }



        }
    }
}
