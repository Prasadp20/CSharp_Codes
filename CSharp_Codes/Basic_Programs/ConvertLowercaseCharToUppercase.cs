using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class ConvertLowercaseCharToUppercase
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the character : ");
			char ch = Convert.ToChar(Console.ReadLine());

			if (ch >= 65 && ch <= 91)
			{
				char character = (char)(ch + 32);
				Console.WriteLine("The Character is : {0}", character);
			}
			else
			{
				char character = (char)(ch - 32);
				Console.WriteLine("The Character is : {0}", character);
			}
		}
	}
}
