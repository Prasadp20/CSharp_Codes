using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.DataTypes_Operators
{
	internal class DemonstrateUseOfConditionalLogicalOperator
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the age : ");
			int age = Convert.ToInt32(Console.ReadLine());

			string validation = age >= 18 ? "true" : "false";

			Console.WriteLine($"Adults : {validation}");

			Console.ReadLine();
		}
	}
}
