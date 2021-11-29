using ProjectoSAD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectoSAD.Data;
using System.Data.Linq;

namespace ProjectoSAD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtName.Text;
            string password = txtPassword.Text;

            SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();
            List<user> users = (List<user>)sad_dwf.users.Where(u => u.email == email && u.password == password).ToList();

            if (users.Count == 1)
            {
                var fname = users.FirstOrDefault().fname;
                var lname = users.FirstOrDefault().lname;

                MessageBox.Show("Bem-vindo " + fname + " " + lname);

                ListaProjectos lp = new Forms.ListaProjectos();
                lp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizador ou password errados.\nPor favor, tentar de novo.");
            }


        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
