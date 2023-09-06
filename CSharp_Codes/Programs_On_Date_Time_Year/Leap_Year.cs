using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Date_Time_Year
{
	internal class Leap_Year
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the year : ");
			int year = Convert.ToInt32(Console.ReadLine());

			if (year <= 0)
			{
				Console.WriteLine("Please enter valid year");
				return;
			}

			bool isLeapYear = (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);

			if (isLeapYear)
			{
				Console.WriteLine($"{year} year is Leap year");
			}
			else
			{

				Console.WriteLine($"{year} year is not a leap year");
			}
		}
	}
}
