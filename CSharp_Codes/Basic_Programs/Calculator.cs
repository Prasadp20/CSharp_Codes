using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class Calculator
	{
		static void Main(string[] args)
		{
			int result = 0;
			Console.Write("Enter the First Number : ");
			int number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the Second Number : ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Main Menu : ");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Multiplication");
			Console.WriteLine("4. Division");

			Console.Write("Enter the Operation you want to perform : ");
			char option = Convert.ToChar(Console.ReadLine());

			switch (option)
			{
				case '1':
					result = number1 + number2;
					Console.WriteLine($"The Result of Addition is : {result}");
					break;
				case '2':
					result = number1 - number2;
					Console.WriteLine($"The Result of Substraction is : {result}");
					break;
				case '3':
					result = number1 * number2;
					Console.WriteLine($"The Result of Multiplication is : {result}");
					break;
				case '4':
					result = number1 / number2;
					Console.WriteLine($"The Result of Division is : {result}");
					break;
				default:
					Console.WriteLine("Choose Proper Option");
					break;
			}
			Console.ReadLine();
		}
	}
}
