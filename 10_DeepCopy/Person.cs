using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seido.Utilities.SeedGenerator;

namespace DeepCopy
{
    public class Person : IPerson, ISeed<Person>
    {
        public bool Seeded { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString() => $"Hi, I'm {FirstName} {LastName}. I was is born on {Birthday:d} " +
            $"and you can reach me on {Email}";

        //Seed a person - your code
        public Person Seed(SeedGenerator rnd)
        {
            return null;
        }

        //Copy constructor - your code
     }
}
