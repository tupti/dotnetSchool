using System;

namespace Week2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Console.ReadKey();
            Exercise2();
            Console.ReadKey();
            Exercise3();
            Console.ReadKey();
            Exercise4();
            Console.ReadKey();
            Exercise5();
            Console.ReadKey();
            Exercise6();
            Console.ReadKey();
            Exercise7();
            Console.ReadKey();
            Exercise8();
            Console.ReadKey();
            Exercise9();
            Console.ReadKey();
            Exercise10();
            Console.ReadKey();
            Exercise11();
            Console.ReadKey();
            Exercise12();
            Console.ReadKey();
            Exercise13();
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
                Console.WriteLine("positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("negative.");
            }
            else
            {
                Console.WriteLine("not positive, but it is also not negative.");
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
            Console.Write("Give me your height (in cm) and I will tell you how tall you are: ");
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

        public static void Exercise7()
        {
            Console.WriteLine("Finding out the biggest number");
            int num1, num2, num3;

            Console.Write("number 1 = ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.Write("number 2 = ");
            Int32.TryParse(Console.ReadLine(), out num2);
            Console.Write("number 3 = ");
            Int32.TryParse(Console.ReadLine(), out num3);

            if (num1 > num2 && num1 > num3)
                Console.WriteLine($"{num1} is the biggest number");
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine($"{num2} is the biggest number");
            else
                Console.WriteLine($"{num3} is the biggest number");
        }

        public static void Exercise8()
        {
            Console.WriteLine("High school exam results:");

            Console.Write("Maths: ");
            int mathsResult = int.Parse(Console.ReadLine());
            Console.Write("Physics: ");
            int physicsResult = int.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            int chemistryResult = int.Parse(Console.ReadLine());

            int resultsSum = mathsResult + physicsResult + chemistryResult;
            bool rule1 = mathsResult > 70 && physicsResult > 55 && chemistryResult > 45 && resultsSum > 180;
            bool rule2 = (mathsResult + physicsResult > 150) || (mathsResult + chemistryResult > 150);

            if (rule1 || rule2)
                Console.WriteLine("Candidate approved!");
            else
                Console.WriteLine("Candidate not approved!");
        }

        public static void Exercise9()
        {
            Console.WriteLine("Enter the temperature in Celsius degrees: ");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature < 0)
                Console.WriteLine("Freezing!");
            else if (temperature >= 0 && temperature < 11)
                Console.WriteLine("Icily!");
            else if (temperature > 10 && temperature < 21)
                Console.WriteLine("Cold!");
            else if (temperature > 20 && temperature < 31)
                Console.WriteLine("Perfect!");
            else if (temperature > 30 && temperature < 41)
                Console.WriteLine("Hot!");
            else
                Console.WriteLine("I'm starting to melt");
        }

        public static void Exercise10()
        {
            Console.Write("Triangle checker. Provide 3 sides.\r\nSide1: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Side2: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Side3: ");
            int side3 = int.Parse(Console.ReadLine());

            if ((side1 + side2 > side3 && side1 + side3 > side2) && side2 + side3 > side1)
                Console.WriteLine("You can build triangle out of this!");
            else
                Console.WriteLine("You cannot build triangle out of this!");
        }

        public static void Exercise11()
        {
            Console.Write("Podaj stopień (1-6): ");
            int input = int.Parse(Console.ReadLine());

            string result = input switch
            {
                1 => "Niedostateczny",
                2 => "Dopuszczający",
                3 => "Dostateczny",
                4 => "Dobry",
                5 => "Bardzo dobry",
                6 => "Celuący",
                _ => "Ocena poza skalą ocen!"
            };

            Console.WriteLine(result);
        }

        public static void Exercise12()
        {
            Console.Write("Podaj numer dnia tygodnia (1-7): ");
            int input = int.Parse(Console.ReadLine());

            string result = input switch
            {
                1 => "Poniedziałek",
                2 => "Wtorek",
                3 => "Środa",
                4 => "Czwartek",
                5 => "Piątek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Nie ma takiego dnia tygodnia!"
            };

            Console.WriteLine(result);
        }

        public static void Exercise13()
        {
            Console.WriteLine("Simple calculator\r\nEnter two values:");

            Console.Write("Value1: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Value2: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Pick (1-4) operation: ");
            Console.WriteLine("1.addition\r\n2.subtraction\r\n3.multiplication\r\n4.division");
            int operation = int.Parse(Console.ReadLine());

            double result = operation switch
            {
                1 => value1 + value2,
                2 => value1 - value2,
                3 => value1 * value2,
                4 => value1 / value2,
                _ => 0,
            };
            Console.WriteLine("Your result: " + result);
        }

    }
}
