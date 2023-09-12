using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Array
{
	internal class sumOfArrayElements
	{
		static void Main(string[] args)
		{
			// Take size veriable
			int size;

			//Take size of array from user
			Console.Write("Enter the size of Array : ");
			size = Convert.ToInt32(Console.ReadLine());

			//Array Declareation
			int[] arr = new int[size];

			//Take values in array from user
			Console.WriteLine("Enter Array Elements : ");
			for (int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("Array : |");
			//Send array and size to print array function and take sum of elements from this method
			int Sum = printArray(arr, size);

			//Print sum of array elements 
			Console.WriteLine($"\nSummation of array elements : {Sum}");
		}

		static int printArray(int[] arr, int size)
		{
			int Sum = 0;

			//For loop to print array elements are calculate sum of array.
			for (int i = 0; i < size; i++)
			{
				Console.Write(arr[i] + "|");
				Sum += arr[i];
			}

			// Return sum to main
			return Sum;
		}
	}
}
