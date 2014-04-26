using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class User
    {
        private User() {  }

        public User(string Email, string Password, Picture PictureProfile) {
            this.Email = Email;
            this.Password = Password;
            this.ProfilePicture = PictureProfile;
        }

        public int Id { get; private set; }
        public string Email { get; private  set; }
        public string Password { get; private  set; }
        public Picture ProfilePicture { get; private set; }

        public void Update(string Password, Picture PictureProfile) {
            this.Password = Password;
            this.ProfilePicture = PictureProfile;
        }
    }
}
