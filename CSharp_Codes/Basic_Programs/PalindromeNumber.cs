using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class PalindromeNumber
	{
		static void Main(string[] args)
		{
			int number, reverseNum = 0, mod;
			Console.Write("Enter the Number : ");
			number = Convert.ToInt32(Console.ReadLine());

			int temp = number;

			while (number > 0)
			{
				mod = number % 10;
				reverseNum = reverseNum * 10 + mod;
				number /= 10;
			}

			Console.WriteLine($"Given number is : {temp}");
			Console.WriteLine($"Its reverse is  = {reverseNum}");

			if (temp == reverseNum)
			{
				Console.WriteLine("Number is a palindrome.");
			}
			else
			{
				Console.WriteLine("Number is not a palindrome.");
			}

			Console.ReadLine();
		}
	}
}
