using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_4
{
    internal class Osoba
    {
        public string Imię { get; private set; }
        public string Nazwisko { get; private set; }

        public Adres Adres { get; set; }

        public string PełenAdres { get => $"{Adres.AdresPocztowy}"; }
        public string Introduce()
        {
            return $"Nazywam się {this.Imię} {this.Nazwisko}.\nAdres: {Adres.AdresPocztowy}";
        }

        public void setData(string imie, string nazwisko, Adres adres)
        {
            this.Imię=imie;
            this.Nazwisko=nazwisko;
            this.Adres=adres;
        }
    }
}
