using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Codes.C__Logical_Programs
{
    internal class PalindromeString
    {
        // Check given String is palindrome or not

        public static bool IsPalindrome(char[] carr, int start, int end) 
        {
            while (start < end)
            {
                if (carr[start] == carr[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write( "Enter the string : ");
            string userString = Console.ReadLine();

            char[] charArray = userString.ToCharArray();
            bool ret = IsPalindrome(charArray, 0, charArray.Length - 1);

            if (ret)
            {
                Console.WriteLine("String is Palindrome\n");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome\n");
            }

            Console.ReadKey();  
        }
    }
}
