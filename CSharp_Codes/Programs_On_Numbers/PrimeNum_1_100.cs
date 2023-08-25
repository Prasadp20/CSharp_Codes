using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class PrimeNum_1_100
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Prime Number between 1 to 100 : ");
			for (int i = 1; i <= 100; i++)
			{
				int count = 0;
				for (int j = 2; j <= i / 2; j++)
				{
					if (i % j == 0)
					{
						count++;
						break;
					}
				}

				if (count == 0)
				{
					Console.Write(i + " ");
				}
			}

			////m = i = 1
			//// n = j = 2
			//int m = 1, n = 2;
			//while (m != 100)
			//{
			//	int prime = (m / 2 % n);

			//	if (prime == 0)
			//	{

			//	}
			//}
		}
	}
}
