using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCCountries;

namespace MVCCountries
{
	internal class CountryController
	{
		public List<Country> CountryDB { get; set; }

		public CountryController()
		{
			CountryDB = new List<Country>()
			{
				new Country("USA", "North America", new List<ConsoleColor >() { ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue }),
				new Country("Brazil", "South America", new List<ConsoleColor >(){ ConsoleColor.Yellow, ConsoleColor.Green}),
				new Country("Poland", "Europe", new List<ConsoleColor>(){ConsoleColor.White, ConsoleColor.Red}),
				new Country("Ukraine", "Europe", new List<ConsoleColor>(){ConsoleColor.Blue, ConsoleColor.Yellow}),
				new Country("Estonia", "Europe", new List<ConsoleColor>(){ConsoleColor.Blue, ConsoleColor.Black, ConsoleColor.White}),
				new Country("Japan", "Asia", new List<ConsoleColor>(){ConsoleColor.Red, ConsoleColor.White})
			};
		}
		public void CountryAction(Country c)
		{
			CountryView cv = new CountryView();
			cv.DisplayCountry = c;
			cv.Display();
		}
		public void WelcomeAction()
		{
			CountryListView countryListView = new CountryListView();
			countryListView.Countries = CountryDB;
			Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
			
		}
		public void CountryListAction()
		{
			CountryListView countryListView = new CountryListView();
			countryListView.Countries = CountryDB;
			countryListView.Display();
			CountryView countryView = new CountryView();
			Console.WriteLine("please input 1-"+CountryDB.Count());
			int index = -1;
			bool goOn = true;
			while (goOn)
			{
				try
				{
					index = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("that isnt a valid number! try again :)");
				}
				if (index == -1 || index == 0 || index == CountryDB.Count() + 1)
				{
					Console.WriteLine("that isnt a valid number! try again :)");
				}
				else
				{
					goOn = false;
				}
			}

			index -= 1;
			CountryAction(CountryDB[index]);

			bool repeat = false;
			do
			{
				Console.WriteLine("would you like to go again? y/n");
				string ans = Console.ReadLine();
				if (ans == "y")
				{
					Console.WriteLine("Welcome back!");
					CountryListAction();
				}
				else if (ans == "n")
				{
					Console.WriteLine("thanks!");
					break;
				}
				else
				{
					Console.WriteLine("didnt catch that, try again (y/n)");
					repeat = true;
				}
			} while (repeat);
		}
	}
}
