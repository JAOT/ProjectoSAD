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
            //this.projectsTableAdapter.Fill(this.sad_dwfDataSet.projects);
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
            decisions_workflowDataContext sad_dwf = new decisions_workflowDataContext();
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
    }
}
