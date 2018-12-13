//Болдин
/*
*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
*/
using System;

namespace SixthApp
{
    public class Prog
    {
        static void Main(string[] args) { }
        public void Print(string msg)
        {
            Console.Write(msg);
        }
        public void Pause()
        {
            Console.ReadKey();
        }
    }
}