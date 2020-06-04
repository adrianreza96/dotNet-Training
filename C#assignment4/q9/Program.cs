using System;
using System.Threading;

namespace NumberPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            string number = Console.ReadLine();
            char[] holder = number.ToCharArray();
            int pivot = holder.Length - 1;
            Boolean compare = true;
            for(int i = 0; i < holder.Length; i++)
            {
                if(i == pivot)
                {
                    break;
                }else if (holder[i] != holder[pivot])
                {
                    compare = false;
                }
                else
                {
                    pivot--;
                }
            }

            Console.WriteLine(compare ?"The number is a palindrome" : "The number is not a palindrome");
        }
    }
}
