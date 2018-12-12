using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstName, age, growth, weight;
            Console.Write("Имя: ");
            name = Console.ReadLine();
            Console.Write("Фамилия: ");
            firstName = Console.ReadLine();
            Console.Write("Возраст: ");
            age = Console.ReadLine();
            Console.Write("Рост: ");
            growth = Console.ReadLine();
            Console.Write("Вес: ");
            weight = Console.ReadLine();
            Console.Clear();
            Console.Write("Имя: {0}\nФамилия{1}\nВозраст: {2}\nРост: {3}\nВес: {4}", name, firstName, age, growth, weight);
            Console.ReadKey();
        }
    }
}
