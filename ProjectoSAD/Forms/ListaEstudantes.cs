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

namespace ProjectoSAD.Forms
{
    public partial class ListaEstudantes : Form
    {
        public ListaEstudantes()
        {
            InitializeComponent();
        }

        private void Estudantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sad_dwfDataSet1.students' table. You can move, or remove it, as needed.
<<<<<<< HEAD
            //this.studentsTableAdapter1.Fill(this.sad_dwfDataSet1.students);
=======
            this.studentsTableAdapter1.Fill(this.sad_dwfDataSet.students);
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
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
<<<<<<< HEAD
                    listaEstudantes = csv.GetRecords<student>().ToList();
                }
                //criação de uma ligação à base de dados
                decisions_workflowDataContext sad_dwf = new decisions_workflowDataContext();
=======
                    //ler todo o conteúdo de ficheiro, importando os registos dos alunos
                    using (var reader = new StreamReader(fich))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        listaEstudantes = csv.GetRecords<student>().ToList();
                    }
                    //criação de uma ligação à base de dados
                    SAD_DWFDataContext sad_dwf = new SAD_DWFDataContext();
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8

                    //preparar as entidades aluno para inserção na tabela
                    foreach (var estudante in listaEstudantes)
                    {
                        //campos com timestamp actual
                        estudante.created_at = DateTime.Now;
                        estudante.updated_at = DateTime.Now;
                        sad_dwf.students.InsertOnSubmit(estudante);
                    }
                    //inserir os registos na tabela
                    sad_dwf.SubmitChanges();
                    //actualizar o tale adapter com os dados acabados de inserir
                    this.studentsTableAdapter1.Fill(this.sad_dwfDataSet.students);
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro de ficheiro");
                }
<<<<<<< HEAD
                //inserir os registos na tabela
                sad_dwf.SubmitChanges();
                //actualizar o tale adapter com os dados acabados de inserir
                //this.studentsTableAdapter1.Fill(this.sad_dwfDataSet1.students);
=======

>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8

            }
        }
    }
}
