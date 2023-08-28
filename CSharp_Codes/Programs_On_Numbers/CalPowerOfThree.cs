using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class CalPowerOfThree
	{
		static void Main(string[] args)
		{
			int cube;
			Console.Write("Enter the limit : ");
			int limit = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Number\tPower of 3");
			for (int j = 1; j <= limit; j++)
			{

				cube = j * j * j;
				Console.WriteLine($"  {j}\t     {cube}");

			}
			Console.ReadKey();
		}
	}
}
