using ProjectoSAD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoSAD.Classes
{
    internal class EntidadeProjectoAtributos
    {
        public int ProjectoID { get; internal set; }
        public List<dwfDataSet.attributesRow> Attributos { get; internal set; }
    }
}
