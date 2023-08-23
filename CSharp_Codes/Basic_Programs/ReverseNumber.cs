using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class ReverseNumber
	{
		static void Main(string[] args)
		{
			int number, revNum = 0, mod;
			Console.Write("Enter a Number : ");
			number = Convert.ToInt32(Console.ReadLine());

			while (number > 0)
			{
				mod = number % 10;
				revNum = revNum * 10 + mod;
				number = number / 10;
			}

			Console.WriteLine($"Reverse of Entered Number : {revNum}");

			Console.ReadLine();
		}
	}
}
