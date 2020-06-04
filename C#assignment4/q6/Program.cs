using System;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a message :");
            string input = Console.ReadLine();
            int count = countWords(input);
            Console.WriteLine("Total number of words are : {0}",count);
        }

        static int countWords(string input)
        {
            string[] words = input.Split(' ');
            return words.Length;
        }
    }
}
