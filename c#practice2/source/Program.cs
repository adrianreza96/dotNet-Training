using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a question number for assignment: ");
                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        question1();
                        continue;
                    case 2:
                        question2();
                        continue;
                    case 3:
                        question3();
                        continue;
                    case 4:
                        question4();
                        continue;
                    case 5:
                        question5(-10, 20);
                        continue;
                    case 6:
                        question6();
                        continue;
                    case 7:
                        question7();
                        continue;
                    case 8:
                        question8();
                        continue;
                    case 9:
                        Console.WriteLine("Enter Width: ");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Height: ");
                        int height = int.Parse(Console.ReadLine());
                        question9(width, height, "*");
                        continue;
                    case 10:
                        question10();
                        continue;
                    case 11:
                        break;

                }
            }
            
        }

        //Q.1
        private static void question1()
        {
            Console.WriteLine("Question 1 : Guess the number! ");
            Console.WriteLine("Enter a number to guess: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == 500)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("FAILURE!");
            }
        }

        //Q.2
        private static void question2()
        {
            Console.WriteLine("Question 2 : Fruits ");
            string[] fruits = { "apple", "banana", "orange" };
            Console.WriteLine(string.Join(" ", fruits));
        }

        //Q.3
        private static void question3()
        {
            Console.WriteLine("Question 3 : Number Replication");
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the repetition amount: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(x);
            }
        }

        //Q.4
        public static void question4()
        {
            Console.WriteLine("Question 4 : Division Calculator");

            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a division: ");
            int y = int.Parse(Console.ReadLine());
            double result = question4_math(x, y);
            Console.WriteLine("Result :{0}",result);
        }

        private static double question4_math(double x,double y)
        {
            return x / y;
        }

        //Q.5
        private static void question5(int seed, int rangeLimit)
        {
            Console.WriteLine("Question 5: Y= x^2 - 2x +1 Calculator");
            // INITIALIZATION
            Console.WriteLine("Seed ={0}, Upper Limit = {1}, interval = {2}", seed, (rangeLimit-1), 1);
            int[] range = new int[rangeLimit ];
            double[] result =new  double[rangeLimit];
            int start = seed;
            for(int i = 0 ;seed < (start+rangeLimit);i++, seed++)
            {
                range[i] = seed;
            }

            //CALCULATIONS
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (range[i]*range[i]) - (2*range[i]) + 1;
            }

            //OUTPUT
            foreach(int element in result)
            {
                Console.WriteLine("Y = {0}",element);
            }

        }

        //Q.6
        private static void question6()
        {
            Console.WriteLine("Question 6: Finding the max between 3 values");
            int[] holder = new int[3];
            for(int i=0;i< holder.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                holder[i] = int.Parse(Console.ReadLine());
            }

            int result = holder.Max(x => x);
            Console.WriteLine("Biggest number is : {0}",result);
        }
        
        //Q.7
        private static void question7()
        {
            Console.WriteLine("Question 7 : Pos/Neg Avg Calculator");
            int[] holder = new int[10];
            int posAvg = 0;
            int posCount = 0;
            int negAvg = 0;
            int negCount = 0;
            Console.WriteLine("Enter in 10 numbers");
            for (int i =0; i <10; i++)
            {
                Console.WriteLine(i == 0 ? " " :"{0} numbers remaining left :", (10 - i)) ;
                holder[i] = int.Parse(Console.ReadLine());
            }
            foreach( int num in holder)
            {
                if (num > 0)
                {
                    posAvg += num;
                    posCount++;
                }
                else
                {
                    negAvg += num;
                    negCount++;
                }
            }
            negCount = negCount == 0 ? 1 : negCount;
            posCount = posCount== 0 ? 1 : posCount;
            Console.WriteLine(posAvg == 0? " ": "Average for positive numbers : {0}", (posAvg/posCount));
            Console.WriteLine(negAvg == 0? " ": "Average for negative numbers : {0}", (negAvg / negCount));
        }

        //Q.8
        private static void question8()
        {
            Console.WriteLine("Question 8: Fibonacci Series");
            Console.WriteLine("Which number of Fibonaci would you like to calculate? (zero-indexed) : ");
            int length = int.Parse(Console.ReadLine());
            int result = fibonacci(length);
            Console.WriteLine("The {0} number of the fibonacci series is : {1}",length, result);
        }

        private static int fibonacci(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }

        //Q.9
        private static void question9(int? x,int? y, string symbol)
        {
            Console.WriteLine("Question 9 : Parallelogram Generator");
            int width = x ?? 10 ;
            int height = y ?? 4;
            Console.WriteLine("Width: {0}, Height: {1}",width,height);
            DrawParallelogram(width, height, symbol);
        }

        
        private static void DrawParallelogram(int width, int height, string symbol)
        {
            for(int row = 0; row < height; row++)
            {
               
                for (int y = 0; y < row; y++)
                {
                    Console.Write("_");
                }
                for (int x = 0; x < width; x++)
                {
                    Console.Write(symbol);
                }
                
                Console.WriteLine();
            }
        }


        //Q.10
        private static void question10()
        {
            Console.WriteLine("Question 10 : Spaces Counter");
            Console.WriteLine("\"Hello, how are you\" contains {0} spaces", CountSpaces("Hello, how are you"));

        }

        private static int CountSpaces(string text)
        {
            int count = 0;
            foreach(char c in text)
            {
                if(c == ' ')
                {
                    count++;
                }
            }
            return count;
        }


    }
}
 