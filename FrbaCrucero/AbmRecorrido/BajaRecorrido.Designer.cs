namespace FrbaCrucero.AbmRecorrido
{
    partial class BajaRecorrido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.gD1C2019DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet1 = new FrbaCrucero.GD1C2019DataSet1();
            this.gD1C2019DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet2 = new FrbaCrucero.GD1C2019DataSet2();
            this.listarecorridosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_recorridosTableAdapter = new FrbaCrucero.GD1C2019DataSet2TableAdapters.lista_recorridosTableAdapter();
            this.cODIGORECORRIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTOORIGENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTODESTINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarecorridosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto Destino";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(426, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGORECORRIDODataGridViewTextBoxColumn,
            this.pUERTOORIGENDataGridViewTextBoxColumn,
            this.pUERTODESTINODataGridViewTextBoxColumn,
            this.pRECIOBASEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewCheckBoxColumn,
            this.Seleccion});
            this.dataGridView1.DataSource = this.listarecorridosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 218);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gD1C2019DataSet
            // 
            this.gD1C2019DataSet.DataSetName = "GD1C2019DataSet";
            this.gD1C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2019DataSetBindingSource
            // 
            this.gD1C2019DataSetBindingSource.DataSource = this.gD1C2019DataSet;
            this.gD1C2019DataSetBindingSource.Position = 0;
            // 
            // gD1C2019DataSet1
            // 
            this.gD1C2019DataSet1.DataSetName = "GD1C2019DataSet1";
            this.gD1C2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2019DataSet1BindingSource
            // 
            this.gD1C2019DataSet1BindingSource.DataSource = this.gD1C2019DataSet1;
            this.gD1C2019DataSet1BindingSource.Position = 0;
            // 
            // gD1C2019DataSet2
            // 
            this.gD1C2019DataSet2.DataSetName = "GD1C2019DataSet2";
            this.gD1C2019DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarecorridosBindingSource
            // 
            this.listarecorridosBindingSource.DataMember = "lista_recorridos";
            this.listarecorridosBindingSource.DataSource = this.gD1C2019DataSet2;
            // 
            // lista_recorridosTableAdapter
            // 
            this.lista_recorridosTableAdapter.ClearBeforeFill = true;
            // 
            // cODIGORECORRIDODataGridViewTextBoxColumn
            // 
            this.cODIGORECORRIDODataGridViewTextBoxColumn.DataPropertyName = "CODIGO_RECORRIDO";
            this.cODIGORECORRIDODataGridViewTextBoxColumn.HeaderText = "CODIGO_RECORRIDO";
            this.cODIGORECORRIDODataGridViewTextBoxColumn.Name = "cODIGORECORRIDODataGridViewTextBoxColumn";
            // 
            // pUERTOORIGENDataGridViewTextBoxColumn
            // 
            this.pUERTOORIGENDataGridViewTextBoxColumn.DataPropertyName = "PUERTO_ORIGEN";
            this.pUERTOORIGENDataGridViewTextBoxColumn.HeaderText = "PUERTO_ORIGEN";
            this.pUERTOORIGENDataGridViewTextBoxColumn.Name = "pUERTOORIGENDataGridViewTextBoxColumn";
            this.pUERTOORIGENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUERTODESTINODataGridViewTextBoxColumn
            // 
            this.pUERTODESTINODataGridViewTextBoxColumn.DataPropertyName = "PUERTO_DESTINO";
            this.pUERTODESTINODataGridViewTextBoxColumn.HeaderText = "PUERTO_DESTINO";
            this.pUERTODESTINODataGridViewTextBoxColumn.Name = "pUERTODESTINODataGridViewTextBoxColumn";
            this.pUERTODESTINODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIOBASEDataGridViewTextBoxColumn
            // 
            this.pRECIOBASEDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_BASE";
            this.pRECIOBASEDataGridViewTextBoxColumn.HeaderText = "PRECIO_BASE";
            this.pRECIOBASEDataGridViewTextBoxColumn.Name = "pRECIOBASEDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewCheckBoxColumn
            // 
            this.eSTADODataGridViewCheckBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewCheckBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewCheckBoxColumn.Name = "eSTADODataGridViewCheckBoxColumn";
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Text = "Eliminar";
            // 
            // BajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 295);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaRecorrido";
            this.Text = "BajaRecorrido";
            this.Load += new System.EventHandler(this.BajaRecorrido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarecorridosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource gD1C2019DataSetBindingSource;
        private GD1C2019DataSet1 gD1C2019DataSet1;
        private System.Windows.Forms.BindingSource gD1C2019DataSet1BindingSource;
        private GD1C2019DataSet2 gD1C2019DataSet2;
        private System.Windows.Forms.BindingSource listarecorridosBindingSource;
        private GD1C2019DataSet2TableAdapters.lista_recorridosTableAdapter lista_recorridosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGORECORRIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTOORIGENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTODESTINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOBASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTADODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
    }
}