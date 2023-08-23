using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class sumDigits
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			int sum = 0, mod;
			while (number > 0)
			{
				mod = number % 10;
				sum = sum + mod;
				number /= 10;
			}

			Console.WriteLine($"Sum of Digits of the Number : {sum}");

			Console.ReadLine();
		}
	}
}
