using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoSAD.ManageProjects
{
    public class Aluno
    {
        public string Name { get; set; }

        public string School { get; set; }

        public string SchoolNumber { get; set; }

        public string Contacts { get; set; }

        public double SaatyIndex { get; set; }

        public double DwfPoints { get; set; }

        public Aluno(string name, string schoolNumber, string contacts, double saatyIndex, double dwfPoints) { 
            Name = name;
            SchoolNumber = schoolNumber;
            Contacts = contacts;
            SaatyIndex = saatyIndex;
            DwfPoints = dwfPoints;
        }

    }
}
