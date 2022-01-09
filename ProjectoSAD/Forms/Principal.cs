using ProjectoSAD.Forms;
using ProjectoSAD.Forms.Inicio;
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
using ProjectoSAD.UserData;

namespace ProjectoSAD
{
    public partial class Principal : Form
    {
        //Apontador para o utilizador actual
        CurrentUser currentUser = new CurrentUser();
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

            dwfDataContext dwfDataContext = new dwfDataContext();
            user user = dwfDataContext.users.Where(u => u.email == email).FirstOrDefault();
            if (user!=null)
            {
                if (txtPassword.Text == DesencriptaPassword(user.password))
                {
                    var fname = user.fname;
                    var lname = user.lname;

                    MessageBox.Show("Bem-vindo " + fname + " " + lname);
                    currentUser = new CurrentUser
                    {
                        name = user.fname + " " + user.lname,
                        phone = user.phone,
                        password = user.password,
                        role = dwfDataContext.roles.Where(r => r.id == user.role_id).FirstOrDefault()
                    };
                    ListaProjectos lp = new Forms.ListaProjectos();
                    lp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Utilizador ou password errados.\nPor favor, tentar de novo.");
                }
            }
            else
            {
                MessageBox.Show("Utilizador não existente ou não encontrado.");
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VerificaCamposVazios())
            {
                //caso todos os campos estejam preenchidos, verificar na bdd se existem algum utilizador com o email indicado
                dwfDataContext dwf = new dwfDataContext();
                user user = dwf.users.Where(u => u.email == txtEmailReg.Text).FirstOrDefault();
                //se não houver, criar um novo
                if (user == null)
                {
                    user regUser = new user
                    {
                        active = 1,
                        created_at = DateTime.Now,
                        email = txtEmailReg.Text,
                        fname = txtFnome.Text,
                        lname = txtLNome.Text,
                        password = EncriptaPassword(txtRegPassword.Text),
                        phone = txtTelemovel.Text,
                        role_id = 1,
                        updated_at = DateTime.Now
                    };
                    dwf.users.InsertOnSubmit(regUser);
                    dwf.SubmitChanges();
                    //limpar as caixas de texto e devolver o utilizador para a form de inicio de sessão
                    txtFnome.Text = "";
                    txtLNome.Text = "";
                    txtTelemovel.Text = "";
                    txtEmailReg.Text = "";
                    txtRegPassword.Text = "";
                    txtRegPasswordVer.Text = "";
                    tabControl1.SelectedTab = tabPage1;
                    MessageBox.Show("Utilizador registado.\nPor favor, faça login.");

                }
                else
                {
                    MessageBox.Show("Já existe um utilizador com esse email.\nNão pode existir mais que um email por utilizador.");
                }
            }
        }
        /// <summary>
        /// Método de desencripta a password
        /// </summary>
        /// <param name="encPassWord"></param>
        /// <returns>A password em texto legível</returns>
        private string DesencriptaPassword(string encPassWord)
        {
            //chave de encriptação
            string EncryptionKey = "p@$sar1nh@";
            //retirar os caracteres problemáticos
            encPassWord = encPassWord.Replace(" ", "+");
            //criação da chave de desencriptação
            byte[] cipherBytes = Convert.FromBase64String(encPassWord);
            //desencriptar a palavra recolhida
            using (Aes encryptor = Aes.Create())
            {
                //criar a chave de derivação
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                //recriar a password em memória
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
            //devolver a password em formato legível
            return encPassWord;
        }

        /// <summary>
        /// Método para encriptação da password, antes de inserção na base de dados
        /// </summary>
        /// <returns>A password encriptada</returns>

        private string EncriptaPassword(string clearText)
        {
            //chave de encriptação, conveniente ser guardada num ficheiro de configuração
            string EncryptionKey = "p@$sar1nh@";
            //tranformação da password inserida num byte[]
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            //início da encripatção da password, com o método AES
            using (Aes encryptor = Aes.Create())
            {
                //derivação da chave de encriptação através da Encryptionkey
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                //escrita da password encriptada em memória
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

        /// <summary>
        /// Verificação dos valores inseridos nas caixas de texto da password 
        /// </summary>
        /// <returns>False, caso as passwords não correspondam, True, caso sejam iguais</returns>
        private bool VerificaConfirmacaoPassword()
        {
            if (txtRegPassword.Text != txtRegPasswordVer.Text)
            {
                MessageBox.Show("A password e a verificação não correspondem.\nAs passwords devem ser iguais.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verificação da informação obrigatória inserida.
        /// </summary>
        /// <returns>False - se algum campo estiver vazio, Procede à verificação da password se estiver tudo preenchido</returns>
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

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
