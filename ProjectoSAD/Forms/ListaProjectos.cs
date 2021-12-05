using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoSAD.Forms
{
    public partial class ListaProjectos : Form
    {
        public ListaProjectos()
        {
            InitializeComponent();
        }

        private void ListaProjectos_Load(object sender, EventArgs e)
        {

        }

        private void ListaProjectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estudantes estudantes = new Estudantes();
            estudantes.Show();

        }
    }
}
