using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.Programs_On_Array
{
    internal class valueEqualToIndex
    {
        public static int valueEqualToIndex1(int[] array, int num)
        {
            for(int i = 1; i <= num; i++)
            {
                if (array[i - 1] == i)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input:\nN = ");
            n = Convert.ToInt32(Console.ReadLine()); 
            int[] arr = new int[n];

            Console.Write("Enter Array Ele : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }

            int ret = valueEqualToIndex1(arr, n);
            Console.WriteLine($"Output : {ret}");
        }
    }
}
