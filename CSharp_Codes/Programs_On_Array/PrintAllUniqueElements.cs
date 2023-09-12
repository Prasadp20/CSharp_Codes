using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Array
{
	internal class PrintAllUniqueElements
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
			Console.Write("The unique elements found in the array are : ");
			PrintUniqueElements(arr, size);

			Console.ReadLine();
		}

		private static void PrintUniqueElements(int[] arr, int size)
		{
			for (int i = 0; i < size - 1; i++)
			{
				bool isUnique = true;

				for (int j = 0; j < i; j++)
				{
					if (arr[i] == arr[j])
					{
						isUnique = false;
						break;
					}
				}

				for (int k = i + 1; k < size; k++)
				{
					if (arr[i] == arr[k])
					{
						isUnique = false;
						break;
					}
				}

				if (isUnique)
				{
					Console.WriteLine(arr[i] + "");
				}
			}
		}
	}
}
