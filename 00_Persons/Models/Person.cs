using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Persons.Models
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public DateTime BirthDay { get; init; }

        public TimeSpan Age => DateTime.Now - BirthDay;


        public override string ToString() => $"{FirstName} {LastName} was born on {BirthDay:D} and is now {Age.Days} days old.";

        //IEquatable
        public bool Equals(Person other) => (FirstName == other.FirstName) && (LastName == other.LastName) && (BirthDay == other.BirthDay);

        public int CompareTo(Person other)
        {
            if (this.Age < other.Age) return 1;
            else if (this.Age == other.Age) return 0;
            return -1;
        }

        public Person()
        {
            var rnd = new Random();
            var fnames = "Idefix, Obelix, Asterix, Trubadix".Split(", ");
            var lnames = "Jetsson, FlintStone, Simson".Split(", "); ;

            FirstName = fnames[rnd.Next(fnames.Length)];
            LastName = lnames[rnd.Next(lnames.Length)];

            BirthDay = new DateTime(rnd.Next(1970, 2020), rnd.Next(1, 13), rnd.Next(1, 29));
        }
    }
}
