using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Введите переменную X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите переменную Y: ");
            y = double.Parse(Console.ReadLine());
            if (x == 0)
            {
                x = y;
                y = 0;
            }
            else if (y == 0)
            {
                y = x;
                x = 0;
            }
            else
            {
                y *= x;
                x = y / x;
                y /= x;
            }
            Console.Write($"X = {x} Y = {y}");
            Console.ReadKey();
        }
    }
}
