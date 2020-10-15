using System;
using System.IO;
using static System.Console;


namespace Factorial_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите целое число:");
            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Для вычисления факториала необходимо ввести целое число:");

            Console.Clear();

            double out_number = Calculate(number);

            Table(out_number, "╔", "═", "╗");
            Table(out_number, "║", "",  "║");
            Table(out_number, "╚", "═", "╝");


            Console.Write("новая колбаса ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ла ла ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ла..");
        }

        static double Calculate(int number)
        {
            double answer = 1, num = (double)number;
            while (num > 0)
            {
                answer *= num;
                num -= 1;
            }
            return answer;
        }

        static void Table(double number, string corner1, string center, string corner2)
        {
            Console.Write(corner1);
            if (center == "")
                Console.Write(number);
            else
            {
                for (int i = 0; i < number.ToString().Length; i++)
                    Console.Write(center);
            }
            Console.WriteLine(corner2);
        }
    }
}