using System;

namespace SquareAndCube_кортеж_
{
    class Program
    {
        static (double, double) SquareAndCube(double x)
        {
            (double, double) result=(Math.Pow(x, 2), Math.Pow(x, 3));
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите переменную");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Для числа {a}, квадрат = {SquareAndCube(a).Item1}, куб = {SquareAndCube(a).Item2}");
            Console.ReadKey();
        }
    }
}
