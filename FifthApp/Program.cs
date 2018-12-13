using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            first.Name = "John";
            first.FirstName = "Bagzzz";
            first.City = "HZ";
            first.GetInfo(first.Name, first.FirstName, first.City);
            Console.ReadKey();
        }
        class Person
        {
            private string name, fitstName, city;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string FirstName
            {
                get { return fitstName; }
                set { fitstName = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public void GetInfo(string msName, string msFirstName, string msCity)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.Write($"{msName} {msFirstName} {msCity}");
            }
        }
    }
}
