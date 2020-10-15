using System;
using static System.Console;


namespace Factorial_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, out_number;
            Console.Write("Введите целое число:");
            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Для вычисления факториала необходимо ввести целое число:");

            out_number = Calculate(number);

            Console.Write(Table("|", "|", "-", LenNumber(number), LenNumber(out_number)));
        }

        static int Calculate(int number)
        {
            int answer = 1;
            while (number > 0)
            {
                answer *= number;
                number -= 1;
            }
            return answer;
        }

        static void Table(string start, string center, string line, int length_intput, int length_output, bool body = false, int number = 0, int answer = 0)
        {
            Console.Write(start);
            if (body)
            {
                Console.Write(number + center + answer);
            }
            else
            {
                for (int i = 0; i < length_intput; i++)
                    Console.Write(line);
                Console.Write(center);
                for (int i = 0; i < length_output; i++)
                    Console.Write(line);
            }
            Console.Write(start);
        }

        static int LenNumber(int number)
        {
            return number.ToString().Length;
        }
    }
}
