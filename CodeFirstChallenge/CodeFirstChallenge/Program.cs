using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //Asks the user for a name, and creates an entry of it in the db
                Console.WriteLine("Please enter your first name!");
                var firstName = Console.ReadLine();

                var student = new Student { firstName = firstName };
                db.Students.Add(student);
                db.SaveChanges();

                // tells the program to select each item (s ) in the db Students
                var getnames = from s in db.Students
                               select s;
                

                // lists each firstName entry for all students in the db
                foreach (var item in getnames)
                {
                    Console.WriteLine("Hey there " + item.firstName + "! " + "Welcome to the Code First approach in a console app!");
                }
            }
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int studentId { get; set; }
        public string firstName { get; set; }

    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}


