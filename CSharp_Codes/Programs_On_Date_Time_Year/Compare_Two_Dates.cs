using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Date_Time_Year
{
	internal class Compare_Two_Dates
	{
		static void Main(string[] args)
		{
			Console.Write("Enter first date in yyyy/MM/dd format : ");
			DateTime firstDate = Convert.ToDateTime(Console.ReadLine());

			Console.Write("Enter second date in yyyy/MM/dd format : ");
			DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

			TimeSpan dateDiff = firstDate - secondDate;

			if (dateDiff.TotalSeconds > 0)
			{

				Console.WriteLine("FirstDate is greater than secondDate.");
			}
			else if (dateDiff.TotalSeconds < 0)
			{

				Console.WriteLine("secondDate is greater than FirstDate.");
			}
			else
			{

				Console.WriteLine("Both dates are same.");
			}
		}
	}
}
