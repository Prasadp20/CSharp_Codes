using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class sumOfMultiples3And5
	{
		static void Main(string[] args)
		{
			int Sum = 0;
			for (int i = 0; i <= 100; i++)
			{
				int a = i % 3;
				int b = i % 5;

				if (a == 0 || b == 0)
				{
					Console.Write($"{i}   ");
					Sum = Sum + i;
				}
			}

			Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}", Sum);
			Console.Read();
		}
	}
}
