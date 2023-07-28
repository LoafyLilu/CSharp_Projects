using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Asks the user for three seprate numbers, saving each in a variable

            Console.WriteLine("Hello there! Please enter a number");
            string userNum1 = Console.ReadLine();
            Console.WriteLine("Great. Please enter another number");
            string userNum2 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string userNum3 = Console.ReadLine();
            

            //Creates a StreamWriter object, and references the file to write to
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Charissa\Desktop\input_assignment.txt"))
            {
                // Writes each variable to the file
                writer.WriteLine(userNum1);
                writer.WriteLine(userNum2);
                writer.WriteLine(userNum3);

            }

            Console.WriteLine("Great. One moment....");

            //Creates a StreamReader object, and referenes the file to read from
            using (StreamReader reader = new StreamReader(@"C:\Users\Charissa\Desktop\input_assignment.txt"))
            {
                // Tells the program to read the entirety of the file
                Console.WriteLine(reader.ReadToEnd());
            }


                Console.WriteLine("Tada!! Here are your numbers, saved to and read from the text file directly!");

            Console.ReadLine();


        }
    }
}
