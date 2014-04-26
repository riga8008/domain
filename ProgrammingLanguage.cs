using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class ProgrammingLanguage
    {
        private   ProgrammingLanguage() { }

        public ProgrammingLanguage(string Name, string Description = null) {
            this.Name = Name;
            this.Description = Description;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public void Update(string Name, string Description) {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
