using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEmel
{
    internal class Program
    {
        static double Function(double x) => Math.Exp(-x) + Math.Pow(x, 2);
        static double FunctionP(double x) => Math.Exp(-x) + 2 * x;

        static void MiddlePoint(int a, int b, double e)
        {
            int Xk = (a + b) / 2;

            if (Math.Abs(b - a) < e)
                Console.WriteLine("Экстремум находится в точке: {0}", Xk);

            else
            {
                double result = Function(Xk);

                if(result < 0)
                {
                    a = a + 1;
                    b = b + 1;
                }

                else
                {
                    a = a + 1;
                    b = Xk;
                }

                MiddlePoint(a, b, e);
            }
        }

        static double Chord(double a, double b, double e)
        {
            double x = 0;
            double temp;

            do
            {
                temp = x;
                x = b - Function(b) * (a - b) / (Function(a) - Function(b));
                a = b;
                b = temp;
            } while (Math.Abs(x - b) > e);

            return x;
        }

        static void Newton(double a, double b, double e)
        {
            double result = a - Function(a) / FunctionP(a);

            if(result < e)
                Console.WriteLine("Экстремум находится в точке: {0}", a);

            else
            {
                if(a < b)
                {
                    a = a + 1;
                    Chord(a, b, e);
                }

                else
                    Console.WriteLine("Точка экстремума не найдена");
            }
        }

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            double e = 0.001;

            Console.Write("Введите начало интервала: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конец интервала: ");
            b = Convert.ToInt32(Console.ReadLine());

            MiddlePoint(a, b, e);
            Console.WriteLine($"Экстремум находится в точке: {Chord(a, b, e)}");

            Newton(a, b, e);


            Console.ReadKey();
        }
    }
}
