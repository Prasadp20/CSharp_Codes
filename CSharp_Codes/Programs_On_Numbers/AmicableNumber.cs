using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class AmicableNumber
	{
		static void Main(string[] args)
		{
			int sum1 = 0, sum2 = 0;
			Console.Write("Enter the first number : ");
			int number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the second number : ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i < number1; i++)
			{
				if (number1 % i == 0)
				{
					sum1 += i;
				}
			}

			for (int i = 1; i < number2; i++)
			{
				if (number2 % i == 0)
				{
					sum2 += i;
				}
			}

			if (number1 == sum2 && number2 == sum1)
			{
				Console.WriteLine("They are a Pair of Amicable Numbers");
			}
			else
			{
				Console.WriteLine("They are not Amicable Numbers");
			}
			Console.ReadKey();
		}
	}
}
