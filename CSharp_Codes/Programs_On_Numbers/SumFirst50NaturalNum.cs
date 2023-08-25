using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class SumFirst50NaturalNum
	{
		static void Main(string[] args)
		{
			int number, Sum = 0;

			for (int i = 1; i <= 50; i++)
			{
				Sum += i;
			}
			Console.WriteLine($"Sum = {Sum}");
			Console.ReadKey();
		}
	}
}
