using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class multiplesOf17
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Multiple of 17 are : ");
			for (int i = 1; i < 100; i++)
			{
				int a = i % 17;
				if (a == 0)
				{
					Console.WriteLine($"{i}");
				}
			}

			Console.ReadLine();
		}
	}
}
