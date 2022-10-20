using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	internal class CountryView
	{
		public Country DisplayCountry { get; set; }
		public void Display()
		{
			Console.WriteLine($"{DisplayCountry.Name} is part of the continent {DisplayCountry.Continent}");
			Console.Write("Its colors are ");
			int colorCount = 0;
			foreach(Enum color in DisplayCountry.Colors)
			{
				colorCount++;
				if(DisplayCountry.Colors.Count() > colorCount)
				{
					Console.ForegroundColor = (ConsoleColor)color;
					Console.Write(color.ToString());
					Console.ForegroundColor = ConsoleColor.Gray;
					if (DisplayCountry.Colors.Count() > 2) { 
						Console.Write(", ");
					}
				}
				else
				{
					if (DisplayCountry.Colors.Count() == 2)
					{
						Console.Write(" ");
					}
					Console.Write("and ");
					Console.ForegroundColor = (ConsoleColor)color;
					Console.Write(color.ToString() + "\n");
					Console.ForegroundColor = ConsoleColor.Gray;
				}
				
			}
		}
	}
}
