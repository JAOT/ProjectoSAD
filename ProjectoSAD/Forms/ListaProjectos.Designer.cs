
using ProjectoSAD.Data;

namespace ProjectoSAD.Forms
{
    partial class ListaProjectos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvProjectos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
<<<<<<< HEAD
            this.saddwfDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
=======
            this.sad_dwfDataSet = new ProjectoSAD.Data.sad_dwfDataSet();
            this.saddwfDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btmImportarListaProjectos = new System.Windows.Forms.Button();
            this.dgvAtributos = new System.Windows.Forms.DataGridView();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sad_dwfDataSet1 = new ProjectoSAD.Data.sad_dwfDataSet();
            this.projectsTableAdapter = new ProjectoSAD.Data.sad_dwfDataSetTableAdapters.projectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad_dwfDataSet)).BeginInit();
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            ((System.ComponentModel.ISupportInitialize)(this.saddwfDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad_dwfDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 126);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1083, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(961, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "BackOffice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar Projecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registar Projecto";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(40, 222);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 57);
            this.button3.TabIndex = 6;
            this.button3.Text = "Alunos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvProjectos
            // 
            this.dgvProjectos.AutoGenerateColumns = false;
            this.dgvProjectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dgvProjectos.DataSource = this.projectsBindingSource;
            this.dgvProjectos.Location = new System.Drawing.Point(368, 222);
            this.dgvProjectos.Name = "dgvProjectos";
            this.dgvProjectos.RowHeadersWidth = 51;
            this.dgvProjectos.RowTemplate.Height = 24;
            this.dgvProjectos.Size = new System.Drawing.Size(300, 476);
            this.dgvProjectos.TabIndex = 7;
            this.dgvProjectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            this.createdatDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.Visible = false;
            this.updatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            // 
            // sad_dwfDataSet
            // 
            // 
            // label3
            // 
<<<<<<< HEAD
=======
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Importar Lista de Projectos";
            // 
            // btmImportarListaProjectos
            // 
            this.btmImportarListaProjectos.Location = new System.Drawing.Point(43, 379);
            this.btmImportarListaProjectos.Name = "btmImportarListaProjectos";
            this.btmImportarListaProjectos.Size = new System.Drawing.Size(278, 77);
            this.btmImportarListaProjectos.TabIndex = 9;
            this.btmImportarListaProjectos.Text = "Abrir Lista";
            this.btmImportarListaProjectos.UseVisualStyleBackColor = true;
            this.btmImportarListaProjectos.Click += new System.EventHandler(this.btmImportarListaProjectos_Click);
            // 
            // dgvAtributos
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            // 
            this.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtributos.Location = new System.Drawing.Point(676, 222);
            this.dgvAtributos.Name = "dgvAtributos";
            this.dgvAtributos.RowHeadersWidth = 51;
            this.dgvAtributos.RowTemplate.Height = 24;
            this.dgvAtributos.Size = new System.Drawing.Size(419, 476);
            this.dgvAtributos.TabIndex = 10;
            this.dgvAtributos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtributos_CellValueChanged);
            // 
<<<<<<< HEAD
            this.saddwfDataSet1BindingSource.Position = 0;
=======
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "attributes";
            this.attributesBindingSource.DataSource = this.sad_dwfDataSet1;
            // 
            // sad_dwfDataSet1
            // 
            this.sad_dwfDataSet1.DataSetName = "sad_dwfDataSet";
            this.sad_dwfDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            // 
            // projectsTableAdapter
            // 
            // 
            // ListaProjectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 710);
            this.Controls.Add(this.dgvAtributos);
            this.Controls.Add(this.btmImportarListaProjectos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProjectos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListaProjectos";
            this.Text = "ListaProjectos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaProjectos_FormClosing);
            this.Load += new System.EventHandler(this.ListaProjectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.sad_dwfDataSet)).EndInit();
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
            ((System.ComponentModel.ISupportInitialize)(this.saddwfDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad_dwfDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvProjectos;
        private System.Windows.Forms.BindingSource saddwfDataSet1BindingSource;
        private System.Windows.Forms.BindingSource projectsBindingSource;
<<<<<<< HEAD
=======
        private Data.sad_dwfDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmImportarListaProjectos;
>>>>>>> 135ed1dbde1f58ff005d66e75df9b7dc7d6786e8
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAtributos;
        private sad_dwfDataSet sad_dwfDataSet1;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private Data.sad_dwfDataSet sad_dwfDataSet;
    }
}