using System;
using System.Collections.Generic;

namespace DzEmel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1

            double result = 0;

            int start = -1;
            int end = 1;

            double a = 28;
            double b = 3;
            double c = -8;
            double d = -4;
            double p = 2;

            List<double> numbers = new List<double>();

            for(int i = start; i <= end; i++)
            {
                result = a * i + b * (i + 1) + c * Math.Pow(i, 2) + d * Math.Pow(i + 1, 2) + p;
                numbers.Add(result);
            }

            numbers.Sort();

            Console.WriteLine("Максимум функции: " + numbers[numbers.Count - 1]);

            //Task_2
            numbers.Clear();

            a = 3;
            b = -1.2;
            c = 0.09;
            d = 0.13;

            for(int i = start; i <= end; i++)
            {
                result = a * i + b * (i + 1) + Math.Exp(c * Math.Pow(i, 2) + d * Math.Pow(i + 2, 2));
                numbers.Add(result);
            }

            numbers.Sort();

            Console.WriteLine("Минимум функции: " + numbers[0]);

            Console.ReadKey();
        }
    }
}
