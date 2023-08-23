using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class SwapsTwoNumbers
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the first numbers : ");
			int number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the second numbers : ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			int temp = number1;
			number1 = number2;
			number2 = temp;

			Console.WriteLine("\nAfter Swapping : \n");
			Console.WriteLine($"First Number : {number1}");
			Console.WriteLine($"Second Number : {number2}");

			Console.ReadLine();
		}
	}
}
