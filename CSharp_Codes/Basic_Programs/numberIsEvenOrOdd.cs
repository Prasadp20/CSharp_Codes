using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharp_Codes.Basic_Programs
{
	internal class numberIsEvenOrOdd
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number % 2 == 0)
			{
				Console.WriteLine("Entered number is an even number.");
			}
			else
			{
				Console.WriteLine("Entered number is an odd number.");
			}
			Console.ReadLine();

		}
	}
}
