using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string firstName;
        public string lastName;
        public float height;
        public float weight;

        public string getData()
        {
            return "Imię i nazwisko: " + firstName + " " + lastName + "\nwzrost: " + height + "cm, waga: " + weight + "kg";
        }
    }
}
