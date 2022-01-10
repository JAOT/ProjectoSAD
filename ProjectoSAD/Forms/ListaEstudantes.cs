using CsvHelper;
using ProjectoSAD.Data;
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
using ProjectoSAD.ManageProjects;


namespace ProjectoSAD.Forms
{
    public partial class ListaEstudantes : Form
    {
        public int projectId;
        
        public ListaEstudantes(int _projectId)
        {
            projectId = _projectId;
            InitializeComponent();
        }

        private void Estudantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sad_dwfDataSet1.students' table. You can move, or remove it, as needed.
            ManageProjects.ManageProjects manageProjects = new ManageProjects.ManageProjects(projectId);

            List<Aluno> studentList = manageProjects.getStudentData();
            int i = 0;
            studentList.ForEach(student => dataGridView1.Rows.Add(++i + "º", student.Name, student.SchoolNumber, student.Contacts, student.DwfPoints, student.SaatyIndex));
        }

        //importar csv
        private void btnImportar_Click(object sender, EventArgs e)
        {
            //Janela de importação de ficheiro
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Ficheiros CSV *.csv|*.csv";
            fileDialog.ShowDialog();

            //foi selecionado um ficheiro csv?            
            if (fileDialog.FileName!="")
            {
                //guardar o nome e caminho do ficheiro
                var fich = fileDialog.FileName;
                //criar uma nova lista de estudantes vazia
                List<student> listaEstudantes;
                try
                {
                    //ler todo o conteúdo de ficheiro, importando os registos dos alunos
                    using (var reader = new StreamReader(fich))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        listaEstudantes = csv.GetRecords<student>().ToList();
                    }
                    //criação de uma ligação à base de dados
                    dwfDataContext dwf = new dwfDataContext();

                    //preparar as entidades aluno para inserção na tabela
                    foreach (var estudante in listaEstudantes)
                    {
                        //campos com timestamp actual
                        estudante.created_at = DateTime.Now;
                        estudante.updated_at = DateTime.Now;
                        dwf.students.InsertOnSubmit(estudante);
                    }
                    //inserir os registos na tabela
                    dwf.SubmitChanges();
                    //actualizar o tale adapter com os dados acabados de inserir
                    this.studentsTableAdapter.Fill(this.dwfDataSet.students);
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro de ficheiro");
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
