using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Instructor : Person
    {
        public Instructor(string Name, string LastName, int Age, PersonGender Gender, string ProfessionalSchedule) 
        : base(Name, LastName, Age, Gender) {
            this.ProcessionalLicense = ProcessionalLicense;
        }

        public string ProcessionalLicense { get; private set; }
        public ICollection<Event>Events{ get; private set; }
        public ICollection<Post> Posts { get; private set; }

        public Event CreateEvent(Event @event) {
            Events.Add(@event);
            return @event;
        }

        public void RemoveEvent(Event @event) {
            Events.Remove(@event);
        }

        public Post CreatePost(Post post) {
            Posts.Add(post);
            return post;
        }

        public void RemovePost(Post post) {
            Posts.Remove(post);
        }
    }
}
