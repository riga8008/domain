using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class Notification
    {
        protected Notification() { }

        public Notification(User User, string Content)
        {
            this.Content = Content;
            this.User = User;
            // Default properties.
            this.CreationDateTime = DateTime.Now;
            this.ModificationDateTime = DateTime.Now;
            this.IsChecked = false;
        }

        public int Id { get; private set; }
        public string Content { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public bool IsChecked { get; private set; }
        public DateTime ModificationDateTime { get; private set; }
        public User User { get; private set; }
        public void Check()
        {
            this.IsChecked = true;
            this.ModificationDateTime = DateTime.Now;
        }

        public void Uncheck()
        {
            this.IsChecked = false;
            this.ModificationDateTime = DateTime.Now;
        }
    }
}
