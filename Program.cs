using System;

namespace Week2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            Exercise6();
            Console.ReadKey();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Integers Equality");

            int num1;
            int num2;

            num1 = 5;
            num2 = 5;

            Console.WriteLine($"{num1} and {num2} are" + ((num1 == num2) ? " " : " not ") + "eqal.");
        }

        public static void Exercise2() 
        {
            Console.WriteLine("Even or Odd?");

            int num = 15;

            Console.WriteLine($"{num} is " + ((num % 2 == 0) ? "even." : "odd."));
        }

        public static void Exercise3()
        {
            Console.WriteLine("Positive or Negative?");

            int num = 14;

            Console.Write($"{num} is ");
            if (num > 0)
            {
                Console.Write("positive.");
            }
            else if (num < 0)
            {
                Console.Write("negative.");
            }
            else
            {
                Console.Write("not positive, but it is also not negative.");
            }
        }

        public static void Exercise4()
        {
            Console.WriteLine("Is leap year?");

            uint year;

            Console.Write("Enter the year to check if it is leap year: ");
            UInt32.TryParse(Console.ReadLine(), out year);
            Console.WriteLine($"{year} is " + ((year % 4 == 0) ? "" : "not ") + "leap year.");
        }

        public static void Exercise5()
        {
            byte age;
            Console.WriteLine("Enter your age: ");
            Byte.TryParse(Console.ReadLine(), out age);
            if (age < 21)
                Console.WriteLine("You cannot run for office.");
            else if (age < 30)
                Console.WriteLine("You can run for Envoy and Prime Minister office.");
            else if (age < 35)
                Console.WriteLine("You can run for Envoy, Prime Minister and Senator office.");
            else
                Console.WriteLine("You can run for Envoy, Prime Minister, Senator and President office.");
        }

        public static void Exercise6()
        {
            int height;
            Console.Write("Give me your height (in cm) and I will tell you, who you are: ");
            Int32.TryParse(Console.ReadLine(), out height);

            if (height <= 140)
                Console.WriteLine("You are dwarf.");
            else if (height <= 160)
                Console.WriteLine("You are short.");
            else if (height <= 170)
                Console.WriteLine("You are medium height.");
            else if (height <= 180)
                Console.WriteLine("You are tall.");
            else if (height <= 200)
                Console.WriteLine("You are very tall.");
            else
                Console.WriteLine("For sure you are basketballer :P");
        }
    }
}
