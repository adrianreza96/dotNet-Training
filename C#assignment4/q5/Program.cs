using System;

namespace vowel_consonant_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            countVowels(input);
        }

        static void countVowels(string input)
        {

            int vowels = 0;
            int consonants = 0;
            foreach (char c in input)
            {
                if (c == 'a'|| c== 'e'|| c== 'i' || c =='o' || c == 'u')
                {
                    vowels++;
                }else if((c >='a' && c <= 'z') || (c >= 'A' && c<= 'Z'))
                {
                    consonants++;
                }
            }

            Console.WriteLine("Total number of vowels : {0}", vowels);
            Console.WriteLine("Total number of consonants : {0}", consonants);

        }
    }
}
