using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Date_Time_Year
{
	internal class Get_the_Local_Time
	{
		static void Main(string[] args)
		{
			TimeZone zone = TimeZone.CurrentTimeZone;
			DateTime local = zone.ToLocalTime(DateTime.Now);
			Console.WriteLine("The Local Time is : {0}", local);

			Console.ReadKey();
		}
	}
}
