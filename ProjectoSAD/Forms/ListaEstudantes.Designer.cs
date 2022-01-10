
using ProjectoSAD.Data;

namespace ProjectoSAD.Forms
{
    partial class ListaEstudantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnImportar = new System.Windows.Forms.Button();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dwfDataSet = new ProjectoSAD.Data.dwfDataSet();
            this.student_attributeTableAdapter = new ProjectoSAD.Data.dwfDataSetTableAdapters.student_attributeTableAdapter();
            this.studentsTableAdapter = new ProjectoSAD.Data.dwfDataSetTableAdapters.studentsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEscola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dwfPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatyIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(12, 12);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(176, 46);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar Ficheiro de alunos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.dwfDataSet;
            // 
            // dwfDataSet
            // 
            this.dwfDataSet.DataSetName = "dwfDataSet";
            this.dwfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_attributeTableAdapter
            // 
            this.student_attributeTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lugar,
            this.nome,
            this.nEscola,
            this.email,
            this.dwfPoints,
            this.saatyIndex});
            this.dataGridView1.Location = new System.Drawing.Point(43, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.MinimumWidth = 6;
            this.lugar.Name = "lugar";
            this.lugar.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // nEscola
            // 
            this.nEscola.HeaderText = "Nº Escola";
            this.nEscola.MinimumWidth = 6;
            this.nEscola.Name = "nEscola";
            this.nEscola.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // dwfPoints
            // 
            this.dwfPoints.HeaderText = "Pontos DWF";
            this.dwfPoints.MinimumWidth = 6;
            this.dwfPoints.Name = "dwfPoints";
            this.dwfPoints.Width = 125;
            // 
            // saatyIndex
            // 
            this.saatyIndex.HeaderText = "Índice Saaty";
            this.saatyIndex.MinimumWidth = 6;
            this.saatyIndex.Name = "saatyIndex";
            this.saatyIndex.Width = 125;
            // 
            // ListaEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImportar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListaEstudantes";
            this.Text = "Estudantes";
            this.Load += new System.EventHandler(this.Estudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private Data.dwfDataSetTableAdapters.student_attributeTableAdapter student_attributeTableAdapter;
        private Data.dwfDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private dwfDataSet dwfDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEscola;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dwfPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatyIndex;
    }
}