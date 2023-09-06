using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Date_Time_Year
{
	internal class Date_In_Various_Formats
	{
		static void Main(string[] args)
		{
			DateTime date = new DateTime(2013, 6, 23);

			Console.WriteLine("Some Date Formats : ");
			Console.WriteLine("Date and Time:  {0}", date);
			Console.WriteLine(date.ToString("yyyy-MM-dd"));
			Console.WriteLine(date.ToString("dd-MMM-yy"));
			Console.WriteLine(date.ToString("M/d/yyyy"));
			Console.WriteLine(date.ToString("M/d/yy"));
			Console.WriteLine(date.ToString("MM/dd/yyyy"));
			Console.WriteLine(date.ToString("MM/dd/yy"));
			Console.WriteLine(date.ToString("yy/MM/dd"));

			Console.Read();
		}
	}
}
