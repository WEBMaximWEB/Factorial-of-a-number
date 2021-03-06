﻿using System;
using System.Threading.Tasks;


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

            // вычисление факториала
            double out_number = Calculate(number);

            bool flag = true; //флаг для смены цвета
            while (true)
            {
                Console.Clear();
                Table(out_number, "╔", "═", "╗");
                Table(out_number, "║", "", "║");
                Table(out_number, "╚", "═", "╝");
                TextColorChange(flag);
                BackgroundColorChange(flag);
                flag = !flag;
                Task.Delay(200).Wait();
            }
            
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

        static void TextColorChange(bool flag)
        {
                if (flag)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;
        }

        static void BackgroundColorChange(bool flag)
        {
            if (flag)
                Console.BackgroundColor = System.ConsoleColor.Blue;
            else
                Console.BackgroundColor = System.ConsoleColor.DarkYellow;
        }
    }
}