using System;

namespace _6._31
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b = 0;
            double c = 0;
            double x = 0;

            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
      
            while (a > 0)
            {
                x = a % 10;
                if (x > b) { b = x; c = 0; }
                if (x == b) c++;
                a /= 10;
            }
            Console.WriteLine(c);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
