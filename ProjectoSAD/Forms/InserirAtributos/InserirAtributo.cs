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
    }
}
