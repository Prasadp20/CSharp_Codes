﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Array
{
	internal class CopyElements
	{
		static void Main(string[] args)
		{
			// Take size veriable
			int size;

			//Take size of array from user
			Console.Write("Enter the size of Array : ");
			size = Convert.ToInt32(Console.ReadLine());

			//Array Declareation
			int[] arr1 = new int[size];
			int[] arr2 = new int[size];

			//Take values in array from user
			Console.WriteLine("Enter Array Elements : ");
			for (int i = 0; i < size; i++)
			{
				arr1[i] = Convert.ToInt32(Console.ReadLine());
			}

			//Pass first array to print function
			Console.Write("The elements stored in the first array are : ");
			printArray(arr1, size);

			// Pass first and second array to copy function
			copyArray(arr1, arr2);

			//Pass first array to print function
			Console.Write("\nThe elements copied into the second array are : ");
			printArray(arr2, size);

			Console.ReadLine();
		}

		static void copyArray(int[] arr1, int[] arr2)
		{
			for (int i = 0; i < arr1.Length; i++)
			{
				arr2[i] = arr1[i];
			}
		}

		static void printArray(int[] arr, int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.Write(arr[i] + "  ");
			}
		}
	}
}
