using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class AcceptHeightOfPersonAndCategorize
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter  the Height (in centimeters) : ");
			int height = Convert.ToInt32(Console.ReadLine());

			if (height <= 150.5)
				Console.WriteLine("Dwarf \n");

			else if (height >= 150.0 && height <= 165.0)
				Console.WriteLine("Average Height \n");

			else if (height >= 165.0 && height <= 195.0)
				Console.WriteLine("Taller \n");

			else
				Console.WriteLine("Abnormal height \n");

			Console.ReadKey();
		}
	}
}
