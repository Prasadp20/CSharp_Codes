using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class FactorsOfGivenNumber
	{
		static void Main(string[] args)
		{
			int number;
			Console.Write("Enter the number : ");
			number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("The Factors are : ");
			for (int i = 1; i <= number; i++)
			{
				if (number % i == 0)
				{
					Console.WriteLine(i);
				}
			}
			Console.ReadKey();
		}
	}
}
