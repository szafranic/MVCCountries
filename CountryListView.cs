using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	internal class CountryListView
	{
		public List<Country> Countries { get; set; }
		public void Display()
		{
			int index = 0;
			foreach (Country country in Countries)
			{
				index++;
				Console.WriteLine(index+": "+country.Name);
			}
		}

	}
}
