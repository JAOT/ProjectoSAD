using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoSAD.Data
{
    internal class GetTables
    {
        public static Table<user> GetUsers()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<user>();
        }
    }
}
