using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Numbers
{
	internal class FibonacciSeries
	{
		static void Main(string[] args)
		{
			int n1 = 0, n2 = 1, n3;

			Console.Write("Enter the Limit : ");
			int limit = Convert.ToInt32(Console.ReadLine());

			Console.Write(n1 + " " + n2 + " ");
			for (int i = 0; i <= limit; i++)
			{
				n3 = n1 + n2;
				Console.Write(n3 + " ");
				n1 = n2;
				n2 = n3;
			}

			Console.ReadLine();
		}
	}
}
