namespace ProjectoSAD.Forms.InserirAtributos
{
    partial class InserirAtributo
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
            this.mtlNome = new MaterialSkin.Controls.MaterialLabel();
            this.mtlPeso = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.mtlLabelProjeto = new MaterialSkin.Controls.MaterialLabel();
            this.mtlInserirBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dwfDataSet = new ProjectoSAD.Data.dwfDataSet();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesTableAdapter = new ProjectoSAD.Data.dwfDataSetTableAdapters.attributesTableAdapter();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtlNome
            // 
            this.mtlNome.AutoSize = true;
            this.mtlNome.Depth = 0;
            this.mtlNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtlNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlNome.Location = new System.Drawing.Point(74, 113);
            this.mtlNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlNome.Name = "mtlNome";
            this.mtlNome.Size = new System.Drawing.Size(50, 19);
            this.mtlNome.TabIndex = 0;
            this.mtlNome.Text = "Nome";
            // 
            // mtlPeso
            // 
            this.mtlPeso.AutoSize = true;
            this.mtlPeso.Depth = 0;
            this.mtlPeso.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtlPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlPeso.Location = new System.Drawing.Point(180, 113);
            this.mtlPeso.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlPeso.Name = "mtlPeso";
            this.mtlPeso.Size = new System.Drawing.Size(43, 19);
            this.mtlPeso.TabIndex = 1;
            this.mtlPeso.Text = "Peso";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(184, 136);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 3;
            // 
            // mtlLabelProjeto
            // 
            this.mtlLabelProjeto.AutoSize = true;
            this.mtlLabelProjeto.Depth = 0;
            this.mtlLabelProjeto.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtlLabelProjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlLabelProjeto.Location = new System.Drawing.Point(176, 9);
            this.mtlLabelProjeto.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlLabelProjeto.Name = "mtlLabelProjeto";
            this.mtlLabelProjeto.Size = new System.Drawing.Size(108, 19);
            this.mtlLabelProjeto.TabIndex = 4;
            this.mtlLabelProjeto.Text = "materialLabel3";
            // 
            // mtlInserirBtn
            // 
            this.mtlInserirBtn.Depth = 0;
            this.mtlInserirBtn.Location = new System.Drawing.Point(290, 133);
            this.mtlInserirBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlInserirBtn.Name = "mtlInserirBtn";
            this.mtlInserirBtn.Primary = true;
            this.mtlInserirBtn.Size = new System.Drawing.Size(75, 23);
            this.mtlInserirBtn.TabIndex = 6;
            this.mtlInserirBtn.Text = "Inserir";
            this.mtlInserirBtn.UseVisualStyleBackColor = true;
            this.mtlInserirBtn.Click += new System.EventHandler(this.mtlInserirBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attributesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 324);
            this.dataGridView1.TabIndex = 7;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
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
            // 
            // attributesBindingSource1
            // 
            this.attributesBindingSource1.DataMember = "attributes";
            this.attributesBindingSource1.DataSource = this.dwfDataSet;
            // 
            // dwfDataSet
            // 
            this.dwfDataSet.DataSetName = "dwfDataSet";
            this.dwfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "attributes";
            this.attributesBindingSource.DataSource = this.dwfDataSet;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 492);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(186, 65);
            this.materialRaisedButton1.TabIndex = 8;
            this.materialRaisedButton1.Text = "Exportar Projecto";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(158, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Inserir Atributo";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(274, 490);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(186, 65);
            this.materialRaisedButton2.TabIndex = 10;
            this.materialRaisedButton2.Text = "Importar Projecto";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // InserirAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 567);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtlInserirBtn);
            this.Controls.Add(this.mtlLabelProjeto);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mtlPeso);
            this.Controls.Add(this.mtlNome);
            this.Name = "InserirAtributo";
            this.Text = "InserirAtributo";
            this.Load += new System.EventHandler(this.InserirAtributo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mtlNome;
        private MaterialSkin.Controls.MaterialLabel mtlPeso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPeso;
        private MaterialSkin.Controls.MaterialLabel mtlLabelProjeto;
        private MaterialSkin.Controls.MaterialRaisedButton mtlInserirBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.dwfDataSet dwfDataSet;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private Data.dwfDataSetTableAdapters.attributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.BindingSource attributesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}