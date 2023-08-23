using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class checkNumberPositiveNegative
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number >= 0)
			{
				Console.Write("Number is Positive.");
			}
			else if (number < 0)
			{
				Console.Write("Number is Negative.");
			}
			Console.ReadLine();
		}
	}
}
