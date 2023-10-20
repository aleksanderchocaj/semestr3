using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Prostokat
    {
        public float boka;
        public float bokb;
        public float pole;
        public string getData()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            return "Pierwszy bok ma długość: " + boka + "cm\nDrugi bok ma długość: " + bokb + "cm\nPole prostokąta wynosi: " + pole + "cm\u00B2";
            Console.OutputEncoding = System.Text.Encoding.Default;
        }
    }
}
