using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoSAD.Forms
{
    public partial class Estudantes : Form
    {
        public Estudantes()
        {
            InitializeComponent();
        }

        private void Estudantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sad_dwfDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter1.Fill(this.sad_dwfDataSet1.students);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            //importar csv
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Ficheiros CSV *.csv|*.csv";
            fileDialog.ShowDialog();
            
            var fich = fileDialog.FileName;
            List<student> listaEstudantes;

            if (fich!=null)
            {
                using (var reader = new StreamReader(fich))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    listaEstudantes = csv.GetRecords<student>().ToList();
                }

                SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();

                foreach (var estudante in listaEstudantes)
                {
                    estudante.created_at = DateTime.Now;
                    estudante.updated_at = DateTime.Now;
                    sad_dwf.students.InsertOnSubmit(estudante);
                }
                sad_dwf.SubmitChanges();
                this.studentsTableAdapter1.Fill(this.sad_dwfDataSet1.students);
            }
        }
    }
}
