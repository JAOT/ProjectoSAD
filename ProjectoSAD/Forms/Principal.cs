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
using System.Security.Cryptography;
using System.IO;

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

            SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();
            user user = sad_dwf.users.Where(u => u.email == email).FirstOrDefault();
            if (txtPassword.Text == DesencriptaPassword(user.password))
            {
                var fname = user.fname;
                var lname = user.lname;

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
            //var encPassWord = EncriptaPassword(txtRegPassword.Text);
            //var decPassword = DesencriptaPassword(encPassWord);
            //verificação de campos em branco no momento do registo
            bool registoOK = VerificaCamposVazios();
            //registoOK = VerificaConfirmacaoPassword();


            if (registoOK)
            {
                SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();
                user user = sad_dwf.users.Where(u => u.email == txtEmailReg.Text).FirstOrDefault();
                if (user == null)
                {
                    user regUser = new user
                    {
                        active = 1,
                        created_at = DateTime.Now,
                        email = txtEmailReg.Text,
                        email_verified_at = DateTime.Now,
                        fname = txtFnome.Text,
                        lname = txtLNome.Text,
                        last_login_at = DateTime.Now,
                        password = EncriptaPassword(txtRegPassword.Text),
                        password_changed_at = DateTime.Now,
                        phone = txtTelemovel.Text,
                        remember_token = "",
                        timezone = TimeZone.CurrentTimeZone.StandardName.ToString(),
                        to_be_logged_out = 1,
                        type_id = 1,
                        updated_at = DateTime.Now

                    };
                    sad_dwf.users.InsertOnSubmit(regUser);
                    sad_dwf.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Já existe um utilizador com esse email.\nNão pode existir mais que um email por utilizador.");
                }
            }
        }

        private string DesencriptaPassword(string encPassWord)
        {
            string EncryptionKey = "p@$sar1nh@";
            encPassWord = encPassWord.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(encPassWord);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    encPassWord = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return encPassWord;
        }

        private string EncriptaPassword(string clearText)
        {
            string EncryptionKey = "p@$sar1nh@";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private bool VerificaConfirmacaoPassword()
        {
            if (txtRegPassword.Text != txtRegPasswordVer.Text)
            {
                MessageBox.Show("A password e a verificação não correspondem.\nAs passwords devem ser iguais.");
                return false;
            }
            return true;
        }

        private bool VerificaCamposVazios()
        {
            if (txtFnome.Text == "" || txtLNome.Text =="" || txtTelemovel.Text =="" || txtEmailReg.Text == "" || txtRegPassword.Text == "" || txtRegPasswordVer.Text == "")
            {
                MessageBox.Show("Um ou mais campos vazios.\nPor favor, rectificar os dados inseridos.");
                return false;
            }
            return VerificaConfirmacaoPassword();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
