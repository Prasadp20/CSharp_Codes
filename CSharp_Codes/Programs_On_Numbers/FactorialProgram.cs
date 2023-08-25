using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class FactorialProgram
	{
		static void Main(string[] args)
		{
			int number, factor = 1;
			Console.Write("Enter the number : ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= number; i++)
			{
				factor *= i;
			}

			Console.WriteLine($"Factorial of Given Number is : {factor}");
		}
	}
}
