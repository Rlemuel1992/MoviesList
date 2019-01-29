using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
	class Program
	{


		static void Main()
		{
			Movies h = new Movies("Chucky", "Horror");
			Movies h1 = new Movies("Nightmare On Elm Street", "Horror");
			Movies h2 = new Movies("Scream", "Horror");
			Movies h3 = new Movies("The Exorcist", "Horror");
			Movies h4 = new Movies("IT", "Horror");
			List<Movies> Horror = new List<Movies>() { h, h1, h2, h3, h4 };



			Movies a = new Movies("Rocky", "Action");
			Movies a1 = new Movies("Terminator", "Action");
			Movies a2 = new Movies("Die Hard", "Action");
			Movies a3 = new Movies("The Matrix", "Action");
			Movies a4 = new Movies("Predator", "Action");
			List<Movies> Action = new List<Movies>() { a, a1, a2, a3, a4 };


			Console.WriteLine("What category would you like to see?(Use numbers)");
			Console.WriteLine("1. Horror  \n" +
							  "2. Action  \n");




			bool run = true;
			while (run == true)
			{
				string input = Console.ReadLine();

				if (input == "1")
				{
					for (int i = 0; i < Horror.Count; i++)
					{
						Movies j = Horror[i];
						j.PrintInfo();
						Console.WriteLine("\n");
					}
					Again();
				}
				else if (input == "2")
				{
					for (int i = 0; i < Action.Count; i++)
					{
						Movies t = Action[i];
						t.PrintInfo();
						Console.WriteLine("\n");
					}
					Again();
				}

				else
					Console.WriteLine("I didn't understand that, try again!");
				run = true;

			}

		}

		public static void Again()
		{
			Console.WriteLine("Did you want to open a different category? y/n");
			string finalInput = Console.ReadLine().ToLower();
			if (finalInput == "y")
			{
				Main();
			}
			else if (finalInput == "n")
			{
				Console.WriteLine("Goodbye!");
				Environment.Exit(1);

			}
			else
				Console.WriteLine("I didn't understand, try again");
			Again();

		}
	}
}
