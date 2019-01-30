using System;

namespace Movies
{
	class Movies
	{
		private string category;
		private string title;



		public Movies(string title, string category)
		{
			this.category = category;
			this.title = title;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Title: {title}");
			Console.WriteLine($"Category: {category}");
		}
	}
}