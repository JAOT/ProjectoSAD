using CsvHelper;
using ProjectoSAD.Data;
using ProjectoSAD.Forms.InserirProjectos;
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
    public partial class ListaProjectos : Form
    {       
        public ListaProjectos()
        {
            InitializeComponent();
        }

        private void ListaProjectos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sad_dwfDataSet.projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.sad_dwfDataSet.projects);
        }

        private void ListaProjectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ao fechar a form, voltar à Form inicial de login. Assume-se que o fechamento desta form sinaliza um logout
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Apresentação da lista de estudantes já integrados
            ListaEstudantes estudantes = new ListaEstudantes();
            estudantes.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //A cada caractere inserido na caixa de texto, são filtrados os nomes dos projectos existentes em sistema
            SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();
            //criação de nova lista vazia
            List<project> filtered = new List<project>();
            //recolha dos projectos existentes na base de dados
            List<project> projectos = sad_dwf.projects.ToList();

            //iteração pela lista de projectos recolhida
            foreach (var item in projectos)
            {
                //recuperação do nome do projecto
                string n = item.name.ToLower();

                //comparação entre o nome do projecto e o valor inserido na caixa de texto
                //ignora-se a existência de maiúculas, convertendo a string para lower case
                if (n.Contains(textBox1.Text.ToLower()))
                {
                    //se existir correspondência, insere-se o projecto na nova lista
                    filtered.Add(item);
                }

            }
            //a lista previamente criada torna-se no dataset apresentado.
            dataGridView1.DataSource = filtered;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirProjeto inserirProjecto = new InserirProjeto();
            inserirProjecto.Show();
            inserirProjecto.FormClosed += InserirProjecto_FormClosed;
        }

        private void InserirProjecto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.projectsTableAdapter.Fill(this.sad_dwfDataSet.projects);
        }

        private void btmImportarListaProjectos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros CSV | *.csv";
            openFileDialog.ShowDialog();
            var resultado = openFileDialog.FileName;

            if (resultado!="")
            {
                //criar uma nova lista de projectos vazia
                List<project> listaProjectos;
                try
                {
                    //ler todo o conteúdo de ficheiro, importando os registos dos projectos
                    using (var reader = new StreamReader(resultado))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {

                        listaProjectos = csv.GetRecords<project>().ToList();
                    }
                    //criação de uma ligação à base de dados
                    SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();

                    //preparar as entidades projecto para inserção na tabela
                    foreach (var project in listaProjectos)
                    {
                        //campos com timestamp actual
                        project.created_at = DateTime.Now;
                        project.updated_at = DateTime.Now;
                        sad_dwf.projects.InsertOnSubmit(project);
                    }
                    //inserir os registos na tabela
                    sad_dwf.SubmitChanges();
                    //actualizar o table adapter com os dados acabados de inserir
                    this.projectsTableAdapter.Fill(this.sad_dwfDataSet.projects);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de ficheiro.");
                }
            }
        }
    }
}
