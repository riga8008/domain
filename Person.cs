using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Person
    {
          private Person() { }

        public Person(string Name, string LastName, int Age, PersonGender Gender) {
            this.Name = Name;
            this.LastName = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public PersonGender Gender { get; private set; }
    }
}
