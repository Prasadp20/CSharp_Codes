using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class LargestPrimeFactorNum
	{
		static void Main(string[] args)
		{
			int num, count = 0;
			Console.Write("Enter the number : ");
			num = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= num; i++)
			{
				if (num % i == 0)
				{
					count++;
				}
			}

			if (count == 2)
			{
				Console.WriteLine("Entered Number is a Prime Number and " + "the Largest Factor is {0}", num);
			}
			else
			{
				Console.WriteLine("Not a Prime Number");
			}
			Console.ReadLine();
		}
	}
}
