namespace Dziedziczenie_2
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }
        public Address Address { get; set; }
        public Person(string name, string surname, DateTime dateofBirth)
        {
            Name = name;
            Surname = surname;
            DateofBirth = dateofBirth;
        }

        public Person(string name, string surname, DateTime dateofBirth, Address address) : this(name, surname, dateofBirth)
        {
            Address = address;
        }

        public string getFullName()
        {
            return Name + " " + Surname;
        }

        public int Age
        {
            get
            {
                TimeSpan difference = DateTime.Now - DateofBirth;
                return (int)(difference.Days / 365.25);
            }
        }
    }

    class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public Address(string city, string street, string houseNumber, string postalCode)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }

    }

    class Student : Person
    {
        public int StudentNUmber { get; set; }
        public Student(string name, string surname, DateTime dateofBirth, int studentNumber) : base(name, surname, dateofBirth)
        {
            StudentNUmber = studentNumber;
        }
        public Student(string name, string surname, DateTime dateofBirth, Address address, int studentNumber) : base(name, surname, dateofBirth, address)
        {
            StudentNUmber = studentNumber;
        }
    }

    class Teacher : Person
    {
        public List<String> Subjects { get; set; }
        public Teacher(string name, string surname, DateTime dateofBirth, Address address, List<string> subjects) : base(name, surname, dateofBirth, address)
        {
            Subjects = subjects;
        }

    }
    internal class Program
    {
        public static List<Person> Users = new List<Person>();
        static void Main(string[] args)
        {
            // Console.WriteLine(DisplayMenu());
            //AddUser();
            //DisplayUsers();

            int option = 0;

            while (option!=4)
            {
                option =DisplayMenu();
                switch(option)
                {
                    case 1: AddUser();
                        break;
                    case 2: DisplayUsers();
                        break;
                    case 3:
                        Users.Clear();
                        Console.WriteLine("Wszyscy użytkownicy zostali usunięci");
                        break;
                    case 4: Console.WriteLine("Wychodzę z programu");
                        break;
                    default: Console.WriteLine("Podano złą wartość");
                        break;
                }
            }
          /*  Person p = new Person("Janusz", "Kowalski", DateTime.Parse("2000-04-01"));
            Console.WriteLine(p.getFullName());
            Console.WriteLine(p.Age);

            Person p_address = new Person("Anna", "Nowak", DateTime.Parse("1999-07-03"), new Address("Poznań", "Poznańska", "1c/2", "62-070"));
            // Console.WriteLine(p_address.Address);
            Student s = new Student("Adam", "Dąbrowski", DateTime.Parse("2000-04-01"), 1234);
            Console.WriteLine(s.getFullName());
            Student s_address = new Student("Zuzanna", "Juskowiak", DateTime.Parse("1999-07-03"), new Address("Poznań", "Poznańska", "1c/2", "62-070"), 12345);

            Teacher nauczyciel = new Teacher("Adam", "Bory", DateTime.Parse("1999-07-03"), new Address("Poznań", "Poznańska", "1c/2", "62-070"), new List<string> { "Matematyka", "Przyroda" });
            Console.WriteLine(nauczyciel.getFullName());
            foreach (string przedmiot in nauczyciel.Subjects)
            {
                Console.WriteLine(przedmiot);
            }*/
        }
        public static int DisplayMenu()
        {
            Console.WriteLine("Program do zarządzanie użytkownikami\n");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Wyświetl użytkowników");
            Console.WriteLine("3. Usuń wszystkich użytkowników");
            Console.WriteLine("4. Wyjdź z programu");
            Console.Write("Wybierz opcję: ");
            return int.Parse(Console.ReadLine());
        }
        public static void AddUser()
        {
            Console.WriteLine("Podaj imię użytkownika:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko użytkownika:");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj datę urodzenia użytkownika (RRRR-MM-DD):");
            DateTime dateofBirth = DateTime.Parse(Console.ReadLine());
            Person uzytkownik = new Person(name, surname, dateofBirth);
            Users.Add(uzytkownik);
            /*   foreach (string uzytkownicy in uzytkownik.Person)
               {
                   Console.WriteLine(uzytkownicy);
               }                   Do sprawdzenia*/

            Console.WriteLine("Użytkownik {0} {1} został dodany", name, surname);
            Console.WriteLine("");          
        }
        public static void DisplayUsers()
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("Brak użytkowników do wyświetlenia");
            }
            else
            {
                Console.WriteLine("Lista użytkowników:\n");
                foreach (Person user in Users) 
                {
                    Console.WriteLine("Imię i nazwisko: {0} {1}, data urodzenia: {2}", user.Name, user.Surname, user.DateofBirth.ToShortDateString());
                }
            }
        }
    }
}