using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class greatestAmongTwoNumbers
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter any two numbers : ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());

			if (number1 > number2)
			{
				Console.Write($"{number1} is the Greatest Number.");
			}
			else if (number2 > number1)
			{
				Console.Write($"{number2} is the Greatest Number.");
			}
			else
			{
				Console.Write($"{number1} and {number2} both are same numbers.");
			}
			Console.ReadLine();
		}
	}
}
