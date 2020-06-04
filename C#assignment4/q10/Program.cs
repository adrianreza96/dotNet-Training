using System;

namespace BinaryEquilavent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary Equivalent is : {0}",binaryRecursion(number));
        }

        static int binaryRecursion(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
                return n%2 + 10*(binaryRecursion(n/2));
            }
            
        }
    }
}
