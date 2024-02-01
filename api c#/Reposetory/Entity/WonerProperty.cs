using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetory.Entity
{
    internal class WonerProperty
    {
        public int id { get; set; }
        public string numphone { get; set; }
        public ICollection<Property> properties { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
    }
}
