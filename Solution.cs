using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Solution
    {
        private  Solution()  { }

        public Solution(Problem Problem, ProgrammingLanguage ProgrammingLanguaje, TimeSpan TimeConsumed, decimal MemoryConsumed, int  TestCasesSolved, decimal Score, string EnvironmentLocation, bool IsSafe, DateTime PublicationDateTime)
        {
            this.TimeConsumed = TimeConsumed;
            this.MemoryConsumed = MemoryConsumed;
            this.TestCasesSolved = TestCasesSolved;
            this.Score = Score;
            this.EnvironmentLocation = EnvironmentLocation;
            this.IsSafe = IsSafe;
            this.Problem = Problem;
            this.ProgrammingLanguage = ProgrammingLanguage;
            this.PublicationDateTime = PublicationDateTime;
            // Default properties
            this.CreationDateTime = DateTime.Now;
        }

        public int Id { get; private set; }
        public TimeSpan TimeConsumed { get; private set; }
        public decimal MemoryConsumed { get; private set; }
        public int TestCasesSolved { get; private set; }
        public decimal Score { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public DateTime PublicationDateTime { get; set; }
        public string EnviromentLocation { get; private set; }
        public bool IsSafe { get; private set; }
        public ProgrammingLanguage ProgrammingLanguage { get; private set; }
        public Problem Problem { get; private set; }

        public string EnvironmentLocation { get; set; }
    }
}
