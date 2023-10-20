using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat = new Prostokat();
            Console.WriteLine("Podaj pierwszy bok: ");
            while (!float.TryParse(Console.ReadLine(), out prostokat.boka) || prostokat.boka<=0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Musisz podać liczbę większą od zera!!!");
                Console.ResetColor();
            }
            Console.WriteLine("Podaj drugi bok: ");
            while (!float.TryParse(Console.ReadLine(), out prostokat.bokb) || prostokat.bokb <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Musisz podać liczbę większą od zera!!!");
                Console.ResetColor();
            }
            prostokat.pole = prostokat.boka * prostokat.bokb;
            Console.WriteLine(prostokat.getData());
        }
    }
}