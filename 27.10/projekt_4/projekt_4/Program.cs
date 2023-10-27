namespace projekt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Osoba osoba = new Osoba();
             //osoba.Imię = "Adam";
             //osoba.Nazwisko = "Chocaj";
             //Console.Write(osoba.Introduce());
             Adres chocajAdres = new Adres() {

                 Ulica = "Poznańska",
             NumerDomu = "1",
             NumerMieszkania = "2",
             KodPocztowy = "62-022",
             Miasto = "Rogalinek",
             Państwo = "Polska",
         };

             osoba.setData("Aleksander", "Chocaj", chocajAdres);
             Console.Write(osoba.Introduce());*/
            Console.WriteLine("Podaj liczbę kontaktów: ");
            int liczbakontaktów = int.Parse(Console.ReadLine());
            Osoba[] ludzie = new Osoba[liczbakontaktów];
            for(int i = 0; i < liczbakontaktów; i++)
            {
                Console.WriteLine($"Podaj imię kontaktu #{i + 1}:");
                string imie = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko kontaktu #{i + 1}:");
                string nazwisko = Console.ReadLine();

                ludzie[i] = new Osoba();

                Console.WriteLine($"Podaj ulicę #{i + 1}:");
                string ulica = Console.ReadLine();

                Console.WriteLine($"Podaj numer domu #{i + 1}:");
                string numerdomu = Console.ReadLine();

                Console.WriteLine($"Podaj numer mieszkania #{i + 1}:");
                string numermieszkania = Console.ReadLine();
            }
        }
    }
}