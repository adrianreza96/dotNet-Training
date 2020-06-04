using System;
using System.Collections.Generic;

namespace displayPattern
{
    class Program
    {
        static Symbol[,] holder;
        static int size;
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter size of diamond (EVEN NUMBERS ONLY) : ");

            size = int.Parse(Console.ReadLine());
            holder = new Symbol[size,size];
            for(int i=0; i < size; i++)
            {
                for(int j=0; j < size; j++)
                {
                    holder[i,j] = new Symbol(" ");
                }
            }
            
            loadPattern(size);
            printPattern();
        }

        // 2n+1 where n is the row number
        // this algorithm uses a n*n matrix
        // Example : n =3 
        //
        //   n=0         _ * _
        //   n=1         * * *
        //   n=2         _ * _
        //
        // this should scale well with any n where n % 2 = 1
        // runtime : N * (n/2 + n/2) => 2N => N
        static void loadPattern(int height)
        {
            Console.WriteLine("Loading Pattern...");
            for(int i = 0; i <= height / 2; i++) // starts from n=0 to n = n/2
            {
                for(int j = height / 2; j < (height / 2) + i; j++) // fill right side of midpoint
                {
                    holder[i,j].text = "*";
                }
                for (int j = (height / 2); j > (height / 2)-i ; j--) // fill left side of midpoint
                {
                    holder[i, j].text = "*";
                }

            }
            for(int i = (height / 2); i < size; i++) // starts from n = n/2 to n = n
            {
                for (int j = (height / 2 ); j < (height / 2) + (size-i) ; j++) // fill right side of midpoint
                {
                    holder[i, j].text = "*";
                }
                for (int j = (height / 2)-1 ; j > (height / 2)- (size - i); j--) // fill left side of midpoint
                {
                    holder[i, j].text = "*";
                }
            }
            Console.WriteLine("Pattern loaded and intialized");
        }

        static void printPattern()
        {
            Console.WriteLine("Printing Pattern...");
            for(int i=0; i < size; i++)
            {
                for(int j =0; j < size; j++)
                {
                    Console.Write(holder[i,j].text);
                }
                Console.WriteLine();
            }
        }
    }

    class Symbol
    {
        public string text;
        public Symbol(string text)
        {
            this.text = text;
        }
    }
}
