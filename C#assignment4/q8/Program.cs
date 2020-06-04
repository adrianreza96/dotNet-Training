using System;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            string number = Console.ReadLine();
            char[] holder = number.ToCharArray();

            int result = 0;
            for(int i = 0; i < holder.Length; i++)
            {
                result += (holder[i] - '0');
            }

            Console.WriteLine("Sum of individual digits is : {0}",result);
        }
    }
}
