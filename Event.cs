using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Event
    {
        private Event() { }

        public Event(string Title, string Description, DateTime InitialDateTime, DateTime FinalDateTime, string EnviromentLocation, EventKind Kind)
        {
            this.Title = Title;
            this.Description = this.Description;
            this.InitialDateTime = InitialDateTime;
            this.FinalDateTime = FinalDateTime;
            this.EnvironmentLocation = EnvironmentLocation;
            this.Kind = Kind;
            // - Default properties.
            this.CreationDateTime = DateTime.Now;
            this.ModificationDateTime = DateTime.Now;
            this.Status = EventStatus.Created;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public DateTime ModificationDateTime { get; private set; }
        public DateTime InitialDateTime { get; private  set; }
        public DateTime FinalDateTime { get; private set; }
        public string EnvironmentLocation { get; private set; }
        public EventKind Kind { get; private set; }
        public EventStatus Status { get; private set; }
        public virtual ICollection<Problem> Problems { get; private set; }
        public virtual ICollection<Student> Students { get; private set; }

        public void Upload() {
            this.Status = EventStatus.Uploaded;
            this.ModificationDateTime = DateTime.Now;
        }

        public void Unload() {
            this.Status = EventStatus.Unloaded;
        }

        public void Cancel() {
            this.Status = EventStatus.Canceled;
        }

        public void Start() {
            this.Status = EventStatus.Started;
        }

        public void Finish() {
            this.Status = EventStatus.Finished;
        }

        public void Archive() {
            this.Status = EventStatus.Archived;
        }

        public void Update(DateTime InitialDateTime, DateTime FinalDateTime) {
            this.InitialDateTime = InitialDateTime;
            this.FinalDateTime = FinalDateTime;
            this.ModificationDateTime = DateTime.Now;
        }

        public void Update(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
            this.ModificationDateTime = DateTime.Now;
        }

        public Problem AddProblem(Problem problem) {
            Problems.Add(problem);
            return problem;
        }

        public void RemoveProblem(Problem problem) {
            Problems.Remove(problem);
        }

        public Student AddStudent(Student student) {
            Students.Add(student);
            return student;
        }

        public void RemoveStudent(Student student) {
            Students.Remove(student);
        }

        public void AddGroup(Group group)
        {
            foreach (var student in group.Students)
            {
                this.AddStudent(student);
            }
        }

        
    }
}
