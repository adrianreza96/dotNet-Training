using System;
using System.Collections.Generic;

namespace StackSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100;
            Stack<int> stack = new Stack<int>(); 
            for(int i = 0; i <size; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("Stack is intialized and values are filled..");


            Console.WriteLine("Enter a number to search in the stack :");
            int obj = int.Parse(Console.ReadLine());
            Boolean found = searchStack(stack, obj);
            Console.WriteLine(found);
        }

        static Boolean searchStack(Stack<int> stack, int obj)
        {
            return stack.Contains(obj);
        }
    }
}
