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
            Console.Write("Имя: " + name +
                "\n Фамилия: " + firstName +
                "\n Возраст: " + age +
                "\n Рост: " + growth +
                "\n Вес: " + weight);
            Console.ReadKey();
        }
    }
}
