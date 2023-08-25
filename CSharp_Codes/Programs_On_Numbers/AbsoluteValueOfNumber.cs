using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class AbsoluteValueOfNumber
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number < 0)
			{
				number = number * -1;
			}

			Console.WriteLine("Absolute value : " + number);
			Console.ReadLine();
		}
	}
}
