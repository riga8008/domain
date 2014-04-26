using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class Clarification
    {
        private Clarification() { }
        
        public Clarification(string Question)
        {
            this.Question = Question;
            // Default properties.
            this.CreationDateTime = DateTime.Now;
            this.ModificationDateTime = DateTime.Now;
            this.IsWaiting = true;
        }
        
        public int Id { get; private set; }
        public string Question { get; private set; }
        public string Answer { get; private set; }
        public bool IsWaiting { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public DateTime ModificationDateTime { get; private set; }
        public ICollection<ClarificationComment> Comments { get; private set; }

        public void Response(string Answer)
        {
            this.Answer = Answer;
        }
    }
}
