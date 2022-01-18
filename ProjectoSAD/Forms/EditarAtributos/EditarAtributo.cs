using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoSAD.Forms.EditarAtributos
{
    public partial class EditarAtributo : Form
    {
        internal string atr1Nome;
        internal string atr2Nome;

        public EditarAtributo()
        {
            InitializeComponent();
        }

        private void EditarAtributo_Load(object sender, EventArgs e)
        {
            materialLabel1.Text = atr1Nome;
            materialLabel2.Text = atr2Nome;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
