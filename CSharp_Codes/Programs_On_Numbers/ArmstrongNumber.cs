using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class ArmstrongNumber
	{
		static void Main(string[] args)
		{
			int number, sum = 0;
			Console.Write("Enter the number : ");
			number = Convert.ToInt32(Console.ReadLine());

			int temp = number;
			while (number > 0)
			{
				int mod = number % 10;
				//sum += CubeFunction(mod);
				sum += mod * mod * mod;
				number = number / 10;
			}

			if (temp == sum)
			{
				Console.WriteLine("Entered Number is an Armstrong Number");
			}
			else
			{
				Console.WriteLine("Entered Number is not an Armstrong Number");
			}

			Console.ReadLine();
		}

		//private static int CubeFunction(int singleDigit)
		//{
		//	int cube = 1;
		//	for (int i = 0; i < 3; i++)
		//	{
		//		cube *= singleDigit;
		//	}
		//	return cube;
		//}
	}
}
