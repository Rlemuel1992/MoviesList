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

			Movies c = new Movies("Water Boy", "Comedy");
			Movies c1 = new Movies("Don't Mess With The Zohan", "Comedy");
			Movies c2 = new Movies("Little Nicky", "Comedy");
			Movies c3 = new Movies("Big Daddy", "Comedy");
			Movies c4 = new Movies("Happy Gilmore", "Comedy");
			Movies c5 = new Movies("Click", "Comedy");
			Movies c6 = new Movies("Adam Sandler", "Comedy");
			Movies c7 = new Movies("Adam Sandler 2", "Comedy");
			Movies c8 = new Movies("Coneheads", "Comedy");
			Movies c9 = new Movies("Mr. Deeds", "Comedy");
			Movies c10 = new Movies("Click", "Comedy");
			Movies c11 = new Movies("8 Crazy Nights", "Comedy");
			Movies c12 = new Movies("Grown Ups 2", "Comedy");
			Movies c13 = new Movies("Hotel Transylvania", "Comedy");
			Movies c14 = new Movies("Billy Madison", "Comedy");
			Movies c15 = new Movies("50 First Dates", "Comedy");
			Movies c16 = new Movies("The Longest Yard", "Comedy");
			Movies c17 = new Movies("The Wedding Singer", "Comedy");
			Movies c18 = new Movies("Anger Management", "Comedy");
			Movies c19 = new Movies("Bedtime Stories", "Comedy");
			Movies c20 = new Movies("Spanglish", "Comedy");
			List<Movies> Comedy = new List<Movies>() { c, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20};

			Movies s = new Movies("Star Trek: The Motion Picture", "Sci-Fi");
			Movies s1 = new Movies("Star Trek II: The Wrath Of Khan", "Sci-Fi");
			Movies s2= new Movies("Star Trek III: The Search For Spock", "Sci-Fi");
			Movies s3 = new Movies("Star Trek IV: The Voyage Home", "Sci-Fi");
			Movies s4 = new Movies("Star Trek V: The Final Frontier", "Sci-Fi");
			Movies s5 = new Movies("Star Trek VI: The Undiscovered Country", "Sci-Fi");
			Movies s6 = new Movies("Star Trek VII: Generations", "Sci-Fi");
			Movies s7 = new Movies("Star Trek VIII: First Contact", "Sci-Fi");
			Movies s8 = new Movies("Star Trek IX: Insurrection", "Sci-Fi");
			Movies s9 = new Movies("Star Trek IX + I: Nemesis", "Sci-Fi");
			Movies s10 = new Movies("Star Trek XI", "Sci-Fi");
			Movies s11 = new Movies("Star Trek XII: Into Darkness", "Sci-Fi");
			Movies s12 = new Movies("Star Trek XII: ", "Sci-Fi");
			List<Movies> SciFi = new List<Movies>() { s, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12};










			Console.WriteLine("What category would you like to see?(Use numbers)");
			Console.WriteLine("1. Horror  \n" +
							  "2. Action  \n" +
							  "3. Adam San...-Comedies \n" +
							  "4. Sci-Fi-Trek \n");


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
						Movies k = Action[i];
						k.PrintInfo();
						Console.WriteLine("\n");
					}
					Again();
				}
				else if (input == "3")
				{
					for (int i = 0; i < Comedy.Count; i++)
					{
						Movies l = Comedy[i];
						l.PrintInfo();
						Console.WriteLine("\n");
					}
					Again();
				}
				else if (input == "4")
				{
					for (int i = 0; i < SciFi.Count; i++)
					{
						Movies m = SciFi[i];
						m.PrintInfo();
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
				Console.WriteLine("Have a shrektastic day");
				Environment.Exit(1);

			}
			else
				Console.WriteLine("I didn't understand, try again");
			Again();

		}
	}
}
