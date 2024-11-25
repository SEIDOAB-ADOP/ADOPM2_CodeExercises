using Seido.Utilities.SeedGenerator;

namespace _00_Persons;

public class Person 
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public DateTime BirthDay { get; init; }

    public TimeSpan Age => DateTime.Now - BirthDay;


    public override string ToString() => $"{FirstName} {LastName} was born on {BirthDay:D} and is now {Age.Days} days old.";

    public Person()
    {
        var rnd = new Random();
        var fnames = "Idefix, Obelix, Asterix, Trubadix".Split(", ");
        var lnames = "Jetsson, FlintStone, Simson".Split(", ");;

        this.FirstName = fnames[rnd.Next(fnames.Length)];
        this.LastName = lnames[rnd.Next(lnames.Length)];

        this.BirthDay = new DateTime(rnd.Next(1970, 2020), rnd.Next(1,13), rnd.Next(1,29));
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, 01_Friends!");

        List<Person> friends = new List<Person>();

        for (int i = 0; i < 100; i++)
        {
            friends.Add(new Person());
        }

        Console.WriteLine();
        Console.WriteLine(friends.Count);
        foreach (var item in friends)
        {
            System.Console.WriteLine(item);
        }
    }
}

// Exercises
//1. Model a person in an immutable class. A person shall have properies, FirstName, LastName, BirthDate, and Age.
//2. Create a list of 100 persons with random names, and birthdates. 
//3. Write the list to the console sorted on age. 


