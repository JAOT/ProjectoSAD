
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_attributeTableAdapter = new ProjectoSAD.Data.dwfDataSetTableAdapters.student_attributeTableAdapter();
            this.studentsTableAdapter = new ProjectoSAD.Data.dwfDataSetTableAdapters.studentsTableAdapter();
            this.dwfDataSet = new ProjectoSAD.Data.dwfDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
=======
<<<<<<< HEAD
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
=======
            this.sad_dwfDataSet = new ProjectoSAD.Data.sad_dwfDataSet();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter1 = new ProjectoSAD.Data.sad_dwfDataSetTableAdapters.studentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad_dwfDataSet)).BeginInit();
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
>>>>>>> b866cbd04461876d339395fbf1d455f2682abfc4
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(9, 10);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(132, 37);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar Ficheiro de alunos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.studentnumberDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 354);
            this.dataGridView1.TabIndex = 1;
            // 
            // student_attributeTableAdapter
            // 
            this.student_attributeTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // dwfDataSet
            // 
            this.dwfDataSet.DataSetName = "dwfDataSet";
            this.dwfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.dwfDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // studentnumberDataGridViewTextBoxColumn
            // 
            this.studentnumberDataGridViewTextBoxColumn.DataPropertyName = "student_number";
            this.studentnumberDataGridViewTextBoxColumn.HeaderText = "student_number";
            this.studentnumberDataGridViewTextBoxColumn.Name = "studentnumberDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
<<<<<<< HEAD
=======
            this.updatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // sad_dwfDataSet1
            // 
<<<<<<< HEAD
=======
            this.sad_dwfDataSet.DataSetName = "sad_dwfDataSet1";
            this.sad_dwfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "students";
<<<<<<< HEAD
=======
            this.studentsBindingSource1.DataSource = this.sad_dwfDataSet;
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            // 
            // studentsTableAdapter1
            // 
>>>>>>> b866cbd04461876d339395fbf1d455f2682abfc4
            // 
            // ListaEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImportar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaEstudantes";
            this.Text = "Estudantes";
            this.Load += new System.EventHandler(this.Estudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.dwfDataSetTableAdapters.student_attributeTableAdapter student_attributeTableAdapter;
        private Data.dwfDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private dwfDataSet dwfDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
<<<<<<< HEAD
=======
<<<<<<< HEAD
        private System.Windows.Forms.BindingSource studentsBindingSource1;
=======
        private sad_dwfDataSet sad_dwfDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private Data.sad_dwfDataSetTableAdapters.studentsTableAdapter studentsTableAdapter1;
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
>>>>>>> b866cbd04461876d339395fbf1d455f2682abfc4
    }
}