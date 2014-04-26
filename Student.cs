using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Student : Person
    {
        public Student(string Name, string LastName, int Age, PersonGender Gender, string Schedule, decimal Score) 
        : base(Name, LastName, Age, Gender)
        {
            this.Schedule = Schedule;
            this.Score = Score;
        }

        public string Schedule { get; private set; }
        public decimal Score { get; private set; }
        public ICollection <Solution> Solutions { get; private set; }
        public ICollection<Clarification> Clarifications { get; private set; }
    }
}
