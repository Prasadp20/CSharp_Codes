using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class ReadGradeDisplayEquivalent_Description
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the Grade : ");
			char grade = Convert.ToChar(Console.ReadLine().ToUpper());

			switch (grade)
			{
				case 'A':
					Console.Write("VERY GOOD");
					break;
				case 'B':
					Console.Write("GOOD");
					break;
				case 'C':
					Console.Write("MODERATE");
					break;
				case 'D':
					Console.Write("NORMAL");
					break;
				case 'E':
					Console.Write("NEED IMPROVEMENT");
					break;
				default:
					Console.WriteLine("Please enter valid grade");
					break;
			}

			Console.ReadLine();
		}
	}
}
