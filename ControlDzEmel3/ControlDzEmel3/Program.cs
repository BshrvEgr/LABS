using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDzEmel3
{
    internal class Program
    {
        static int TaskThree(int a, int d, int b, int c1, int c2) => (b / a) * c1 + (b / d) * c2;

        static double FunctionOne(int m, int x1, int x2) => (m + 7) * x1 + (m + 8) * x2;

        static double FunctionTwo(int m, int n, int x1, int x2) => Math.Pow(x1 - n, 2) + Math.Pow(x2 - m, 2);

        static void Main(string[] args)
        {
            //Task_3

            List<int> profit = new List<int>();

            int a_1 = 1;
            int d_1 = 3;
            int b_1 = 300;

            int a_2 = 3;
            int d_2 = 4;
            int b_2 = 477;

            int a_3 = 4;
            int d_3 = 1;
            int b_3 = 441;

            int c_1 = 52000;
            int c_2 = 39000;

            profit.Add(TaskThree(a_1, d_1, b_1, c_1, c_2));
            profit.Add(TaskThree(a_2, d_2, b_2, c_1, c_2));
            profit.Add(TaskThree(a_3, d_3, b_3, c_1, c_2));

            profit.Sort();

            Console.WriteLine($"Максимальная прибыль: {profit[profit.Count - 1]} руб");

            //Task_4

            int[,] products = new int[4, 4]
            {
                {2, 4, 2, 3 },
                {5, 2, 4, 5 },
                {4, 6, 4, 2 },
                {0, 0, 0, 0}
            };

            int result = products[0, 0] * 30 + products[1, 0] * 50 + products[1, 1] * 50 + products[1, 2] * 100
                + products[2, 0] * 30 + products[2, 3] * 40 + products[3, 0] * 190;

            Console.WriteLine("Минимальный расход: " + result);

            //Task_5

            int prevLast = 3;
            int x1 = 3;
            int x2 = 4;

            double rez = FunctionOne(prevLast, x1, x2);

            Console.WriteLine("F(Task_5) = " + rez);

            //Task_6
            int last = 7;

            rez = FunctionTwo(prevLast, last, x1, x2);
            Console.WriteLine("F(Task_6) = " + rez);


            Console.ReadKey();
        }
    }
}
