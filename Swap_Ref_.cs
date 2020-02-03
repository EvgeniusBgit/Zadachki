using System;

namespace Swap_Ref_
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int z;
            z = x;
            x = y;
            y = z;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите переменную А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную B");
            int b = Convert.ToInt32(Console.ReadLine());
            Program.Swap(ref a, ref b);
            Console.WriteLine($"A={a}, B={b}");
            Console.ReadKey();
        }

    }
}
