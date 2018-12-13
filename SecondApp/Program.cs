//Болдин
/*
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            Console.Write("Рост в метрах: ");
            first.Growth = double.Parse(Console.ReadLine());
            Console.Write("Вес в килограммах: ");
            first.Weight = double.Parse(Console.ReadLine());
            first.IMT(first.Weight, first.Growth);
            Console.Write($"Масса тела = {first.GetIMT:F2}");
            Console.ReadKey();
        }
    }

    class Person
    {
        private double growth, weight, imt;
        public double Growth
        {
            get { return growth; }
            set { growth = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double GetIMT
        {
            get { return imt; }
        }
        public void IMT(double m, double h)
        {
            imt = m / (h * h);
        }
    }
}