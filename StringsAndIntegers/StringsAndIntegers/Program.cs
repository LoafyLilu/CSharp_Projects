using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
			/* This block establishes a list of numbers, requests the user
				to enter a number, and converts the string value to an int
			*/

			int[] numbers = { 2, 3, 4, 7, 9 };


			/* The foreach block runs each number in the list against the user input.
				The console then displays the results to the user. However, this does not
				prepare for any possible exceptions. If the user enters a non whole number, a zero,
				or a string they will receive the standard system generated exception message.
				Lets fix that by creating a try-catch loop! This will handle exceptions with
				a simple message to the user, rather than something confusing!
			*/
			Console.WriteLine("Please enter a number to divide the list by!");
			

				try
				{
					int userNum = Convert.ToInt32(Console.ReadLine());
					foreach (int n in numbers)
					{
						Console.WriteLine(n + " divided by " + userNum + " equals " + n / userNum + "!");
					}	
				}

				catch (FormatException ex)
				{
					// This will display a simplified system message
					Console.WriteLine(ex.Message);
					Console.ReadLine();

					//This will display a custom message to the user
					//Console.WriteLine("Please enter a whole number");
				}

				catch (DivideByZeroException ex)
				{
					Console.WriteLine(ex.Message);
					//Console.WriteLine("Please don't divide by zero");
				}

				catch (Exception ex)
				{
					//This will catch any additional exceptions not accounted for
					//Console.WriteLine(ex.Message);
					Console.WriteLine("Input is in an incorrect format! Sorry :/ ");
				}

				finally
				{
					Console.ReadLine();
				}

				

		
		}
    }
}
