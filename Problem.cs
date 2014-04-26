using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Problem
    {
        private Problem() { }

        public Problem(Event Event, TimeSpan TimeLimit, int MemoryLimit, int MinimumTestCases, string EnviromentLocation)
        {
            this.TimeLimit = TimeLimit;
            this.MemoryLimit = MemoryLimit;
            this.MininumTestCases = MininumTestCases;
            this.EnvironmentLocation = this.Event.EnvironmentLocation;
            this.Event = Event;
            // Default properties
            this.CreationDateTime = DateTime.Now;
            this.ModificationDateTime = DateTime.Now;
            this.Status = ProblemStatus.Created;
        }

        public int Id { get; private set; }
        public decimal MemoryLimit { get; private set; }
        public TimeSpan TimeLimit { get; private set; }
        public int MininumTestCases { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public DateTime ModificationDateTime { get; private set; }
        public string EnvironmentLocation { get; private set; }
        public Event Event { get; private set; }
        public ProblemStatus Status { get; private set; }
        public ICollection<Clarification> Clarifications { get; private set; }

        public void Upload() 
        {
            this.ModificationDateTime = DateTime.Now;
            this.Status = ProblemStatus.Loaded;
        }

        public void Unload()
        {
            this.ModificationDateTime = DateTime.Now;
            this.Status = ProblemStatus.Unloaded;
        }

        public void Cancel() 
        {
            this.ModificationDateTime = DateTime.Now;
            this.Status = ProblemStatus.Canceled;
        }
    }
}
