using Seido.Utilities.SeedGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_interfaces.Models;

public record PersonAsRecord(string FirstName, string LastName, string Email) : IPerson
{
    public PersonAsRecord():this(null, null, null)
    {}
    public IPerson Seed(SeedGenerator seeder)
    {
        var fn = seeder.FirstName;
        var ln = seeder.LastName;
        return new PersonAsRecord(fn, ln, seeder.Email(fn, ln));
    }
}

