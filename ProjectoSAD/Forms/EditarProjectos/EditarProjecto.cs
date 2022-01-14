using ClosedXML.Excel;
using ProjectoSAD.Classes;
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

namespace ProjectoSAD.Forms.InserirAtributos
{
    public partial class InserirAtributo : Form
    {
        public int IDProjecto { get; set; }
        dwfDataContext dwf = new dwfDataContext();
        public InserirAtributo(int idProjecto)
        {
            IDProjecto = idProjecto;
            InitializeComponent();
            mtlLabelProjeto.Text = dwf.projects.Where(p => p.id == IDProjecto).FirstOrDefault().name;

        }

        private void mtlInserirBtn_Click(object sender, EventArgs e)
        {
            //validar se o valor inserido na caixa de texto "Peso" é um valor numérico
            int peso = 0;
            bool numerico = int.TryParse(txtPeso.Text, out peso);
            if (numerico)
            {
                attribute attribute = new attribute
                {
                     project_id = IDProjecto,
                     name = txtNome.Text,
                     weight = peso,
                     created_at = DateTime.Now,
                     updated_at = DateTime.Now,
                };
                dwf.attributes.InsertOnSubmit(attribute);
                dwf.SubmitChanges();
                this.attributesTableAdapter.FillBy(this.dwfDataSet.attributes, IDProjecto);
            }
            else
            {
                MessageBox.Show("O valor inserido no campo 'Peso' não é válido.");
            }
        }

        private void InserirAtributo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dwfDataSet.attributes' table. You can move, or remove it, as needed.
            //var lista = this.dwfDataSet.attributes.Where(a => a.id == IDProjecto);

            this.attributesTableAdapter.FillBy(this.dwfDataSet.attributes, IDProjecto);
            mtlLabelProjeto.Font = new Font("Arial", 22);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            List<dwfDataSet.attributesRow> attributes = dwfDataSet.attributes.Where(a => a.project_id == IDProjecto).ToList();

            var workBook = new XLWorkbook();
            string pNome = dwf.projects.Where(p => p.id == IDProjecto).FirstOrDefault().name;
            workBook.AddWorksheet(pNome);
            var ws = workBook.Worksheet(pNome);

            ws.Cell(1, 1).Value = "Nome do Projecto";
            ws.Cell(1, 2).Value = "Nome do Aluno";
            int coluna = 3;
            foreach (var atr in attributes)
            {
                ws.Cell(1, coluna).Value = atr.name;
                coluna++;
            }
            int row = 2;
            List<student_project> sPrj = dwf.student_projects.Where(sp => sp.project_id == IDProjecto).ToList();

            foreach(var a in sPrj)
            {
                var al = dwf.students.Where(aluno => aluno.id == a.student_id).FirstOrDefault();
                ws.Cell(row, 1).Value = pNome;
                ws.Cell(row, 2).Value = al.name;
                row++;
            }
            try
            {
                workBook.SaveAs(@"d:\dwf_" + pNome + ".xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação do ficheiro.");
            }
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros EXCEL  (*.xlsx) | *.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var workBook = new XLWorkbook(openFileDialog.FileName);
                    var ws = workBook.Worksheets.FirstOrDefault();
                    var linhas = ws.RowsUsed().Count();
                    var colunas = ws.ColumnsUsed().Count();

                    //obter os dados de projecto, e lista de atributos de cada linha
                    //cabeçalho
                    //nome do projecto, descobrir o id
                    var idProjecto = dwf.projects.Where(p => p.name.Equals(ws.Cell(1, 1).Value.ToString()));
                    //lista dinâmica dos ids dos atributos
                    List<int> idAttributos = new List<int>();
                    //
                    for (int j = 3; j <= colunas; j++)
                    {
                        idAttributos.Add(dwf.attributes.Where(s => s.name.Equals(ws.Cell(1, j).Value.ToString())).FirstOrDefault().id);
                    }

                    //obter os pesos de cada atributo do aluno e inserir da tabela da base de dados (tabela student_atribute)
                    for (int i = 2; i <= linhas; i++)
                    {
                        var x = ws.Cell(1, 2).Value;
                        var idAluno = dwf.students.Where(s => s.name.Equals(ws.Cell(i, 2).Value.ToString())).FirstOrDefault().id;
                        int coluna = 3;

                        foreach (var idAtr in idAttributos)
                        {
                            student_attribute student_Attribute = new student_attribute
                            {
                                attribute_id = idAtr,
                                student_id = idAluno,
                                student_evaluation = int.Parse(ws.Cell(i, coluna).Value.ToString()),
                                created_at = DateTime.Now,
                                updated_at= DateTime.Now
                            };


                            dwf.student_attributes.InsertOnSubmit(student_Attribute);
                            dwf.SubmitChanges();
                            coluna++;
                        }
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Erro de acesso ao ficheiro");
                }

            }
        }
    }
}
