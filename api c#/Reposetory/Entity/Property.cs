using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetory.Entity
{
    internal class Property
    {

        public int id { get; set; }
        public string address { get; set; }
        public int propertyowner { get; set; }
        public int price { get; set; }
        public double sqKm{ get; set; }
        public int NumRoom { get; set; }
        public int Numfloor { get; set; }
        public string  propertyType { get; set; }
        public string Propertycharacteristics { get; set; }
        public string propertycondition { get; set; }    

    }
}
