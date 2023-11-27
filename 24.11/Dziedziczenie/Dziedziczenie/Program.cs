namespace Dziedziczenie
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }
        public Address Address { get; set; }
        public Person (string name, string surname, DateTime dateofBirth)
        {
            Name = name;
            Surname = surname;
            DateofBirth = dateofBirth;
        }

        public Person(string name, string surname, DateTime dateofBirth, Address address): this(name, surname, dateofBirth)
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
                return (int)(difference.Days/365.25);
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
        public List<String> Subjects {  get; set; }
        public Teacher(string name, string surname, DateTime dateofBirth, Address address, List<string> subjects) : base(name, surname, dateofBirth, address)
        {
            Subjects = subjects;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Janusz", "Kowalski", DateTime.Parse("2000-04-01"));
            Console.WriteLine(p.getFullName());
            Console.WriteLine(p.Age);

            Person p_address = new Person("Anna", "Nowak", DateTime.Parse("1999-07-03"), new Address("Poznań", "Poznańska", "1c/2", "62-070"));
            // Console.WriteLine(p_address.Address);
            Student s = new Student("Adam", "Dąbrowski", DateTime.Parse("2000-04-01"), 1234);
            Console.WriteLine(s.getFullName());
            Student s_address = new Student("Zuzanna", "Juskowiak", DateTime.Parse("1999-07-03"), new Address("Poznań", "Poznańska", "1c/2", "62-070"), 12345);

            Teacher nauczyciel = new Teacher("Adam", "Bory", DateTime.Parse("1999-07-03"), new Address("Poznań", "Poznańska", "1c/2", "62-070"), new List<string> {"Matematyka", "Przyroda"});
            Console.WriteLine(nauczyciel.getFullName());
            foreach (string przedmiot in nauczyciel.Subjects)
            {
                Console.WriteLine(przedmiot);
            }
        }
    }
}