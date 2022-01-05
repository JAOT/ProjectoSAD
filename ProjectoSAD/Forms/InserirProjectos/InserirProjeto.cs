using ProjectoSAD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoSAD.Forms.InserirProjectos
{
    public partial class InserirProjeto : Form
    {
        public InserirProjeto()
        {
            InitializeComponent();
        }

        private void btnInserirProjeto_Click(object sender, EventArgs e)
        {
            if (txtNomeProjeto.Text!="")
            {
                project newProject = new project
                {
                    id = 0,
                    name = txtNomeProjeto.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                dwfDataContext dwf = new dwfDataContext();
                dwf.projects.InsertOnSubmit(newProject);
                dwf.SubmitChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("O campo Nome do projeto não pode estar vazio.");
            }
        }

        private void InserirProjeto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
