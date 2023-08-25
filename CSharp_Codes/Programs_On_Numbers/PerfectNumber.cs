using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class PerfectNumber
	{
		static void Main(string[] args)
		{
			int sum = 0;
			Console.Write("Enter the number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i < number; i++)
			{
				if (number % i == 0)
				{
					sum += i;
				}
			}

			if (number == sum)
			{
				Console.WriteLine("Entered Number is a Perfect Number");
			}
			else
			{
				Console.WriteLine("Entered Number is not a Perfect Number");
			}

			Console.ReadKey();
		}
	}
}
