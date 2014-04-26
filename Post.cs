using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities.Enums;

namespace Cain.Domain.Entities
{
    public class Post
    {
        private Post() { }

        public Post(string Title, string Description, string Content, ICollection<string> Tags) {
            this.Title = Title;
            this.Description = Description;
            this.EnvironmentLocation = EnvironmentLocation;
            this.Tags = Tags;
            // Default properties.
            this.CreationDateTime = DateTime.Now;
            this.ModificationDateTime = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public DateTime ModificationDateTime { get; private set; }
        public string EnvironmentLocation { get; private set; }
        public PostStatus Status { get; private set; }
        public ICollection<string> Tags { get; private  set; }
        public ICollection<PostComment> Comments { get; private set; }

        public void Upload()
        {
            this.Status = PostStatus.Uploaded;
            this.ModificationDateTime = DateTime.Now;
        }

        public void Unload()
        {
            this.Status = PostStatus.Unloaded;
            this.ModificationDateTime = DateTime.Now;
        }
    }
}
