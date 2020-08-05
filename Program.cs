using System;

namespace Week2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Console.ReadKey();
        }
        public static void Exercise1()
        {
            string name = "Jan";
            string surname = "Nowak";
            byte age = 56;
            char sex = 'm';
            long PESEL = 64050512345;
            long employeeId = 2509324094;            

            Console.WriteLine($"Employee data\r\n Name:{name},\r\n Surname:{surname},\r\n Age:{age},\r\n Sex:{sex},\r\n PESEL:{PESEL},\r\n Employee ID:{employeeId}\r\n");
        }
        public static void Exercise2()
        {
            Console.WriteLine("Reverting 3 characters");
            Console.Write("First letter: ");
            char first = char.Parse(Console.ReadLine());
            Console.Write("Second letter: ");
            char second = char.Parse(Console.ReadLine());
            Console.Write("Third letter: ");
            char third = char.Parse(Console.ReadLine());
            Console.WriteLine($"Reverted order:{third},{second},{first}\r\n");
        }
        public static void Exercise3()
        {
            Console.WriteLine("Diagonal of a Rectangle Calculator");
            Console.Write("Enter rectangle length:");
            double length = Double.Parse(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = Double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));

            Console.WriteLine($"Result: {width} x {length} rectangle diagonal equals {diagonal}.\r\n");
        }
        public static void Exercise4()
        {
            int firstNum;
            string word;
            double secondNum;

            firstNum = 10;
            word = "dotnet School";
            secondNum = 12.5;

            Console.WriteLine($"Declared variables:\r\nfirstNum = '{firstNum}', word = '{word}', secondNum = '{secondNum}'\r\n");
        }
        public static void Exercise5()
        {
            Console.WriteLine("Hello stranger :-) Please fill this form:");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Phone number: ");
            int phoneNum = int.Parse(Console.ReadLine());

            Console.Write("E-mail address: ");
            string mail = Console.ReadLine();

            Console.Write("Height(cm): ");
            byte height = byte.Parse(Console.ReadLine());

            Console.Write("Weight(kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {firstName} {surname} from {city}. You provided following data:\r\n Age:{age},\r\n Phone:{phoneNum},\r\n e-mail:{mail},\r\n Height(cm):{height},\r\n Weight(kg):{weight}");
        }
    }

}