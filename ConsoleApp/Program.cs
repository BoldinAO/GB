using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixthApp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Prog p = new Prog();
            Person first = new Person();

            p.Print("Имя: ");
            first.Name = Console.ReadLine();
            p.Print("Фамилия: ");
            first.FirstName = Console.ReadLine();
            p.Print("Возраст: ");
            first.Age = Console.ReadLine();
            p.Print("Рост: ");
            first.Growth = Console.ReadLine();
            p.Print("Вес: ");
            first.Weight = Console.ReadLine();
            p.Print($"Имя: {first.Name}\nФамилия: {first.FirstName}\nВозраст: {first.Age}\nРост: {first.Growth}\nВес: {first.Weight}");
            p.Pause();
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
