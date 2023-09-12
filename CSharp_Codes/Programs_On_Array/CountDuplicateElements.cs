using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Array
{
	internal class CountDuplicateElements
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

			//Pass array to print function
			Console.Write("The elements stored in the array are : ");
			printArray(arr, size);

			int count = duplicateEleCount(arr, size);
			Console.Write($"\nTotal number of duplicate elements found in the array is : {count}");

			Console.ReadLine();
		}

		static void printArray(int[] arr, int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.Write(arr[i] + "  ");
			}
		}

		static int duplicateEleCount(int[] arr, int size)
		{
			int Count = 0;
			for (int i = 0; i < size - 1; i++)
			{
				for (int j = i + 1; j < size; j++)
				{
					if (arr[i] == arr[j])
					{
						Count++;
					}
				}
			}
			return Count;
		}
	}
}
