using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class numIsDivisibleByTwo
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number % 2 == 0)
			{
				Console.WriteLine("Entered Number is Divisible by 2.");
			}
			else
			{
				Console.WriteLine("Entered Number is Not Divisible by 2.");
			}

			Console.ReadLine();
		}
	}
}
