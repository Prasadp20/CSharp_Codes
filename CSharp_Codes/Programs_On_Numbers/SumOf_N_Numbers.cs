using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class SumOf_N_Numbers
	{
		static void Main(string[] args)
		{
			int nthNumber, Sum = 0;
			Console.Write("Enter the Nth Number : ");
			nthNumber = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i <= nthNumber; i++)
			{
				Sum += i;
			}

			Console.WriteLine($"Sum of N Numbers : {Sum}");

			Console.ReadKey();
		}
	}
}
