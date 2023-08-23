using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Basic_Programs
{
	internal class MultiplicationOf2BinaryNum
	{
		static void Main(string[] args)
		{
			SumOf2BinaryNum binaryNum = new SumOf2BinaryNum();

			Console.Write("Enter the First Binary Number : ");
			int binary1 = Convert.ToInt32(Console.ReadLine());
			int decimalNum1 = binaryNum.binaryToDecimal(binary1);

			Console.Write("Enter the Second Binary Number : ");
			int binary2 = Convert.ToInt32(Console.ReadLine());
			int decimalNum2 = binaryNum.binaryToDecimal(binary2);

			int mult = decimalNum1 * decimalNum2;
			int MultOfbinary = binaryNum.DecimalToBinary(mult);
			Console.WriteLine($"Multiplication of Two Binary Numbers : {MultOfbinary}");
		}
		public int binaryToDecimal(int number)
		{
			int decimalNum = 0;
			int[] array = number.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
			int[] decimalArray = new int[array.Length];

			int i = 0, j = array.Length - 1;
			while (i < array.Length)
			{

				decimalArray[i] = array[i] * Convert.ToInt32(Math.Pow(2, j));
				--j;
				++i;
			}
			for (int k = array.Length - 1; k >= 0; k--)
			{
				decimalNum = decimalNum + decimalArray[k];
			}
			return decimalNum;
		}
		public int DecimalToBinary(int number)
		{
			int[] array = new int[8];
			int mod;
			if (number != 0)
			{
				for (int i = 7; i >= 0; i--)
				{
					mod = number % 2;
					number = number / 2;
					array[i] = mod;
				}
			}
			int binaryNum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				binaryNum += array[i] * Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
			}
			return binaryNum;
		}
	}
}
