using System;

namespace SquareAndCube_OUT_
{
    class Program
    {
        static void SquareAndCube(double x, out double y, out double z)
        {
            y = Math.Pow(x, 2);
            z = Math.Pow(x, 3);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите переменную");
            double a = Convert.ToDouble(Console.ReadLine());
            double Square;
            double Cube;
            SquareAndCube(a,out Square,out Cube);
            Console.WriteLine($"Для числа {a} квадрат равен {Square}, куб равен {Cube} ");
            Console.ReadKey();
        }

    }
}
