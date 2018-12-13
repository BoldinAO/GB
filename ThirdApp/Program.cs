using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point();
            Console.Write("x1 = ");
            pt.X1 = Int32.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            pt.Y1 = Int32.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            pt.X2 = Int32.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            pt.Y2 = Int32.Parse(Console.ReadLine());
            pt.CalcDistance();
            Console.Write($"Расстояние между точками = {pt.GetDistance:F2}");
            Console.ReadKey();
        }
    }

    class Point
    {
        private int x1, y1, x2, y2;
        private double r;
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public double GetDistance
        {
            get { return r; }
        }
        public void CalcDistance()
        {
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
