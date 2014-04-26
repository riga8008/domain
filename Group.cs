using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class Group
    {
        protected Group() {  }
        public Group(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            // Default properties.
            CreationDateTime = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public ICollection<Student> Students { get; private set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
