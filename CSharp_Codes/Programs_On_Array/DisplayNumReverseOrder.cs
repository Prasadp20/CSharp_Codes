using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Array
{
	internal class DisplayNumReverseOrder
	{
		static void Main(string[] args)
		{
			int size;
			Console.Write("Enter the size of Array : ");
			size = Convert.ToInt32(Console.ReadLine());

			int[] arr = new int[size];

			Console.WriteLine("Enter Array Elements : ");
			for (int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("Array in normal order : ");
			printArray(arr, size);

			reverseArray(arr, size);
			Console.WriteLine();

			Console.Write("Array in rverse order : ");
			printArray(arr, size);

			Console.ReadLine();
		}

		static void printArray(int[] arr, int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.Write(arr[i] + "  ");
			}
		}
		static void reverseArray(int[] arr, int size)
		{
			int start = 0;
			int end = size - 1;
			while (start < end)
			{
				int temp = arr[start];
				arr[start] = arr[end];
				arr[end] = temp;

				start++;
				end--;
			}
		}
	}
}
