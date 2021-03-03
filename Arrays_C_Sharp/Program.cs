using System;

namespace Out_Ref
{
    class Program
    {
        //ref = для змінної, яка має прийти ініціалізована
        //out = для змінної, яка МОЖЕ прийти НЕініціалізована
        //generic
        static void Swap<T>(ref T one, ref T two) //copy values
        {
            T tmp = one;
            one = two;
            two = tmp;
        }
        static bool SquareEquation(double a, double b, double c, out double x1, out double x2)
        { 
            double D = Math.Pow(b,2) - 4 * a * c;
            if (D < 0)
            {
                x1 = x2 = double.NaN;
                return false;
            }
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);

            return true;
        }
        static void Main(string[] args)
        {
            int f = 10, s = 20;
            Swap(ref f, ref s);
            Console.WriteLine($"One:{f,-7}Two:{s, -7}");

            double a=1, b=5, c=3, x1, x2;
            if(SquareEquation(a, b, c, out x1, out x2))
            {
                Console.WriteLine($"x1 = {x1:F2} x2 = {x2:F4}");
            }
            else
                Console.WriteLine("Fail");

        }
    }
}
