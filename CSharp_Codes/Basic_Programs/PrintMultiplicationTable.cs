using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class PrintMultiplicationTable
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number : ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number <= 0)
			{
				Console.WriteLine("Enter the number greater than 0.");
			}

			Console.WriteLine("Multiplication Table : ");
			for (int i = 1; i <= number; i++)
			{
				for (int j = 1; j <= number; j++)
				{
					Console.Write("{0}  ", i * j);
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
