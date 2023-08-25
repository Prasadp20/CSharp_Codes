using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class SquareRootOfNumber
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number : ");
			int number = Convert.ToInt32(Console.ReadLine());
			int temp = number;
			int count = 0;
			int i = 1;
			while (number != 0)
			{
				number -= i;
				i = i + 2;
				count++;
			}
			Console.WriteLine("Square Root of {0} is {1}", temp, count);

		}
	}
}
