using Seido.Utilities.SeedGenerator;

namespace _00_Persons;

public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; set; }

    public DateTime BirthDay { get; set; }


    public override string ToString() => $"{FirstName} {LastName} was born on {BirthDay:D}";
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, 01_Friends!");

        //Create a generator, inherited from .NET Random
        var rnd = new SeedGenerator();


        List<Person> _friends = new List<Person>();

        for (int i = 0; i < 5_000; i++)
        {
            _friends.Add(new Person()
            {
                FirstName = rnd.FirstName,
                LastName = rnd.LastName,
                BirthDay = rnd.DateAndTime(1970, 2020)
            });
        }

        Console.WriteLine();
        Console.WriteLine(_friends.Count);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(_friends[i]);
        }
    }
}

// Exercises
// 1. Create a list of 100 000 Friends with firstname, lastname and birthays between 1970 and 2020

