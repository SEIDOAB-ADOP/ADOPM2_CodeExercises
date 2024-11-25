using Microsoft.AspNetCore.Mvc.Diagnostics;
using Seido.Utilities.SeedGenerator;
using _00_Persons.Models;

namespace _00_Persons;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, 01_Friends!");

        var p3 = new Person() { LastName = "Lenart", BirthDay = new DateTime(1964,03,25) };
        var p4 = new Person() { LastName = "Lenart", BirthDay = new DateTime(1964,03,25) };
        System.Console.WriteLine(p3.Equals(p4));



        List<Person> friends = new List<Person>();

        for (int i = 0; i < 100; i++)
        {
            friends.Add(new Person());
        }

        friends.Sort();
       

        Console.WriteLine();
        Console.WriteLine(friends.Count);
        foreach (var item in friends)
        {
            System.Console.WriteLine(item.ToString());
        }
    }
}

// Exercises
//1. Model a person in an immutable class. A person shall have properies, FirstName, LastName, BirthDate, and Age.
//2. Create a list of 100 persons with random names, and birthdates. 
//3. Write the list to the console sorted on age. 


