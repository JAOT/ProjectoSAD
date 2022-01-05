using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoSAD.Models
{
    class WeightedAttribute
    {
        public int weight { get; set; }
        public string name { get; set; }
        public long projectoID { get; internal set; }
        public long attributeID { get; internal set; }
    }
}
