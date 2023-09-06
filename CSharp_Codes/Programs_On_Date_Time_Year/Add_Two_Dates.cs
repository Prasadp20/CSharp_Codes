using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Date_Time_Year
{
	internal class Add_Two_Dates
	{
		static void Main(string[] args)
		{
			DateTime sDate = new DateTime(2023, 09, 01);
			Console.WriteLine("Starting date : {0}", sDate);
			DateTime eDate = sDate.AddDays(10);
			Console.WriteLine("Ending date : {0}", eDate);

			Console.ReadKey();
		}
	}
}
