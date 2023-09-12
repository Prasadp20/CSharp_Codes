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

			Console.Write("Enter Array Elements : ");
			for (int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("Array in normal order : ");
			for (int i = 0; i < size; i++)
			{
				Console.Write(arr[i] + " ");
			}

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

			Console.WriteLine();

			Console.Write("Array in rverse order : ");
			for (int i = 0; i < size; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}
