using System.Text;

public struct Person : IComparable<Person>
{
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Surname have to have 3 symbols at least");
            _name = value;
        }
    }

    public string Surname
    {
        get => _surname;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Surname have to have 3 symbols at least");
            _surname = value;
        }
    }
    
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException( "", "Age have to be more than 0");
            _age = value;
        }
    }

    private string _name;
    private string _surname;
    private int _age;

    public Person(string name, string surname, int age)
    {
        if (age < 0)
            throw new ArgumentOutOfRangeException( "", "Age have to be more than 0");
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Surname have to have 3 symbols at least");
        if (string.IsNullOrEmpty(surname))
            throw new ArgumentException("Surname have to have 3 symbols at least");

        _name = name;
        _surname = surname;
        _age = age;
    }

    public int CompareTo(Person person)
    {
        if (this.Age > person.Age) return 1;
        if (this.Age == person.Age) return 0;
        return -1;
    }

    public override string ToString() => $"Name - {Name}\nSurname - {Surname}\nAge - {Age}\n";
}

class Program
{
    static void Main()
    {
        int.TryParse(Console.ReadLine(), out var n);
        var persons = new Person[n];
        for (var i = 0; i < n; i++)
        {
            Random r = new();
            
            var k = r.Next(3, 10);
            var s = new StringBuilder("");
            s.Append((char) r.Next(65, 91));
            for (var j = 0; j < k - 1; j++)
            {
                s.Append((char) r.Next(97, 123));
            }
            var surname = s.ToString();

            k = r.Next(3, 9);
            s = new StringBuilder("");
            s.Append((char) r.Next(65, 91));
            for (var j = 0; j < k - 1; j++)
            {
                s.Append((char) r.Next(97, 123));
            }
            var name = s.ToString();

            persons[i] = new Person(name, surname, r.Next(0, 101));
        }
        
        Array.ForEach(persons,x => Console.WriteLine(x));
        Array.Sort(persons); // дурацкий требуемый способ
        // persons = persons.OrderBy(x => x.Age).ToArray(); // нормальный способ
        Array.ForEach(persons,x => Console.WriteLine(x));
        
    }
}