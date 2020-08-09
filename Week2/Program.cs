using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }

        public static void Exercise1() 
        {
            Console.WriteLine("Prime numbers (0-100):");
            for (int i = 0; i <= 100; i++) 
            {
                if (i < 2) continue;
                if (isPrime(i))
                    Console.WriteLine(i);
            }

            bool isPrime(int num)
            {
                for (int i = 2; i < num; i++)
                    if (num % i == 0)
                        return false;
                return true;
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Even numbers 1-1000:");
            int index = 1;
            do
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine(index);
                }
                index++;
            } while (index <= 1000);
        }

        public static void Exercise3()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the N of elements in Fibonacci series: ");
            number = int.Parse(Console.ReadLine());
            if (number == n1)
                Console.WriteLine(n1);
            else if (number < 0)
                Console.WriteLine("C'mon guys, be serious :P");
            else
                Console.Write(n1 + " " + n2 + " ");  
                for (i = 1; i < number; ++i) 
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            Console.WriteLine();
        }

        public static void Exercise4()
        {
            int floors = 1;
            int counter = 0;
            int number;
            Console.Write("Insert number: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (counter < floors)
                {
                    Console.Write(i + " ");
                    counter++;
                }
                else
                {
                    Console.Write("\r\n");
                    counter = 0;
                    floors++;
                    i--;
                }     
            }
        }


    }
}
