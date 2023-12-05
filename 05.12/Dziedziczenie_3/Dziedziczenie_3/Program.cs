namespace Dziedziczenie_3
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
        public int StudentNumber { get; set; }
        public Student(string name, string surname, DateTime dateofBirth, int studentNumber) : base(name, surname, dateofBirth)
        {
            StudentNumber = studentNumber;
        }
        public Student(string name, string surname, DateTime dateofBirth, Address address, int studentNumber) : base(name, surname, dateofBirth, address)
        {
            StudentNumber = studentNumber;
        }
    }

    class Teacher : Person
    {
        public List<String> Subjects { get; set; }
        public Teacher(string name, string surname, DateTime dateofBirth, List<string> subjects) : base(name, surname, dateofBirth)
        {
            Subjects = subjects;
        }

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

            while (option != 8)
            {
                option = DisplayMenu();
                switch (option)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        DisplayUsers();
                        break;
                    case 3:
                        AddStudent();
                        break;
                    case 4:
                        DisplayStudents();
                        break;
                    case 5:
                        AddTeacher();
                        break;
                    case 6:
                        DisplayTeachers();
                        break;
                    case 7:
                        Users.Clear();
                        Console.WriteLine("Wszyscy użytkownicy zostali usunięci");
                        break;
                    case 8:
                        Console.WriteLine("Wychodzę z programu");
                        break;
                    default:
                        Console.WriteLine("Podano złą wartość");
                        break;
                }
            }
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Program do zarządzanie użytkownikami\n");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Wyświetl użytkowników");
            Console.WriteLine("3. Dodaj studenta");
            Console.WriteLine("4. Wyświetl studentów");
            Console.WriteLine("5. Dodaj nauczyciela");
            Console.WriteLine("6. Wyświetl nauczycieli");
            Console.WriteLine("7. Usuń wszystkich użytkowników");
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

        public static void AddStudent()
        {
            Console.WriteLine("Podaj imię studenta: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko studenta: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj datę urodzenia studenta (YYYY-MM-DD): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer indeksu studenta: ");
            int studentNumber = int.Parse(Console.ReadLine());

            Student student = new Student(name, surname, dateOfBirth, studentNumber);
            Users.Add(student);
            Console.WriteLine($"\nStudent {name} {surname} został dodany");
        }

        public static void AddTeacher()
        {
            Console.WriteLine("Podaj imię nauczyciela: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko nauczyciela: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj datę urodzenia nauczyciela (YYYY-MM-DD): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę przedmiotów nauczyciela: ");
            int subjectCount = int.Parse(Console.ReadLine());
            List<string> subjects = new List<string>();

            for(int i = 0; i < subjectCount; i++)
            {
                Console.WriteLine($"Podaj nazwy przedmiotu: {i + 1}");
                string subject = Console.ReadLine();
                subjects.Add(subject);
            }

            Teacher teacher = new Teacher(name, surname, dateOfBirth, subjects);
            Users.Add(teacher);
            Console.WriteLine($"\nNauczyciel {name} {surname} został dodany");
            Console.WriteLine("Przedmioty: {0}\n", string.Join(",", ((Teacher)teacher).Subjects));
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

        public static void DisplayStudents()
        {
              int count = 0;
                foreach (Person student in Users)
                {
                    if (student is Student)
                    {
                    count++;
                    Console.WriteLine("Lista studentów:\n");
                    Console.WriteLine("Imię i nazwisko: {0} {1}, data urodzenia: {2}, numer indeksu: {3}", student.Name, student.Surname, student.DateofBirth.ToShortDateString(), ((Student)(student)).StudentNumber);
                    }
                    if (count == 0)
                    {
                    Console.WriteLine("Brak studentów do wyświetlenia");
                    }
                }
        }

        public static void DisplayTeachers()
        {
                int count = 0;
                foreach (Person teacher in Users)
                {                  
                    if (teacher is Teacher)
                    {
                        count++;
                        Console.WriteLine("Lista nauczycieli:\n");
                        Console.WriteLine("Imię i nazwisko: {0} {1}, data urodzenia: {2}", teacher.Name, teacher.Surname, teacher.DateofBirth.ToShortDateString());
                    }
                    if(count == 0)
                {
                    Console.WriteLine("Brak nauczycieli do wyświetlenia");
                }
                }
        }
    }
}