using CSharp_Codes.Basic_Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class ArmstrongNumbetween_1_to_1000
	{
		static void Main(string[] args)
		{
			Console.Write("Armstrong number between 1 to 1000 : ");
			for (int temp = 1; temp <= 1000; temp++)
			{
				int sum = 0;
				int number = temp;
				while (number > 0)
				{
					int mod = number % 10;
					sum += mod * mod * mod;
					number = number / 10;
				}

				if (temp == sum)
				{
					Console.Write(temp + "  ");
				}
			}
			Console.ReadLine();
		}
	}
}
