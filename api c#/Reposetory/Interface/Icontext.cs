using Reposetory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetory.Interface
{
    internal interface Icontext
    {
        public Dbset<Property> propety { get; set; }
        public Dbset<wonerProperty> wonerproperty { get; set; }
        public Dbset<PropertySercher> propertyserch { get; set; }
    }
}
