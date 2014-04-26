using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class Picture
    {
        private Picture() { }

        public Picture(string EnviromentLocation) {
            this.EnviromentLocation = EnviromentLocation;
        }

        public int Id { get; private set; }
        public string EnviromentLocation { get; private set; }
    }
}
