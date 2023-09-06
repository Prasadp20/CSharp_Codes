using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Date_Time_Year
{
	internal class Get_Universal_Time
	{
		static void Main(string[] args)
		{
			TimeZone zone = TimeZone.CurrentTimeZone;
			DateTime univ = zone.ToUniversalTime(DateTime.Now);
			Console.WriteLine("Universal Time is : {0}", univ);

			Console.ReadKey();
		}
	}
}
