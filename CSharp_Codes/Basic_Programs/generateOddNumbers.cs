using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class generateOddNumbers
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the range of number to print odd numbers between them");
			Console.Write("From : ");
			int fromNumber = Convert.ToInt32(Console.ReadLine());
			Console.Write("To : ");
			int toNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();
			for (int i = fromNumber; i <= toNumber; i++)
			{
				if (i % 2 != 0)
				{
					Console.Write(i + "  ");
				}
			}
			Console.ReadLine();
		}
	}
}
