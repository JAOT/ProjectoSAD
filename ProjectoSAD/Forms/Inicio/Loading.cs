using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectoSAD.Forms;
using System.Windows.Forms;

namespace ProjectoSAD.Forms.Inicio
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
   
            if (this.progressBar1.Value == this.progressBar1.Maximum) {
                    var welcome = new Principal();
                    welcome.Show();
                    this.Hide();
                    this.timer1.Stop(); 
            } else if (this.progressBar1.Value == (int)this.progressBar1.Maximum/2) {
                this.label1.Text = "A mudar o aspeto da aplicação...";
                this.progressBar1.Value += 1;
            } else if (this.progressBar1.Value == (int)this.progressBar1.Maximum - 10) {
                this.label1.Text = "A preparar os retoques finais...";
                this.progressBar1.Value += 1;
            }
            else { this.progressBar1.Value += 1; }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
