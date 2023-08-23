using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class DivisionOfExponentsOfSameBase
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the Base : ");
			int Base = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the First Exponent : ");
			int exp1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the Second Exponent : ");
			int exp2 = Convert.ToInt32(Console.ReadLine());

			int divExponent = exp1 / exp2;

			Console.Write("Result is : {0}^{1} : {2}", Base, divExponent, Math.Pow(Base, divExponent));

			Console.ReadLine();
		}
	}
}
