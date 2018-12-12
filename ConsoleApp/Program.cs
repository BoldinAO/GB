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
            Person first = new Person();
            Console.Write("Имя: ");
            first.Name = Console.ReadLine();
            Console.Write("Фамилия: ");
            first.FirstName = Console.ReadLine();
            Console.Write("Возраст: ");
            first.Age = Console.ReadLine();
            Console.Write("Рост: ");
            first.Growth = Console.ReadLine();
            Console.Write("Вес: ");
            first.Weight = Console.ReadLine();
            Console.Write($"Имя: {first.Name}\nФамилия: {first.FirstName}\nВозраст: {first.Age}\nРост: {first.Growth}\nВес: {first.Weight}");
            Console.ReadKey();
        }
    }

    class Person
    {
        private string name, firstName, age, growth, weight;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Growth
        {
            get { return growth; }
            set { growth = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
