using System;
using System.Collections.Generic;

namespace TPS.Data.Users
{
    public class Person : IPerson
    {
        public int PersonId { get; set; }

        public Name Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Genders Gender { get; set; }

        public ICollection<Address> EmailAddresses { get; set; }

        public ICollection<Location> Locations { get; set; }
    }

    public interface IPerson
    {
        int PersonId { get; set; }
    }
}