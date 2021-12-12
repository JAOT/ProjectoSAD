using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectoSAD.Data;

namespace ProjectoSAD.UserData
{
    class CurrentUser
    {
        public string name { get; internal set; }
        public string phone { get; internal set; }
        public string password { get; internal set; }

        public type type { get; internal set; }
        public role role { get; internal set; }
    }
}
