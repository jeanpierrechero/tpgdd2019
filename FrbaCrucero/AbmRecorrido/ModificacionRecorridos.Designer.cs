namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificacionRecorridos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2019DataSet4 = new FrbaCrucero.GD1C2019DataSet4();
            this.listarecorridosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_recorridosTableAdapter = new FrbaCrucero.GD1C2019DataSet4TableAdapters.lista_recorridosTableAdapter();
            this.cODIGORECORRIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTOORIGENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTODESTINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_solo_activos = new System.Windows.Forms.CheckBox();
            this.checkBox_solo_no_activos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarecorridosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // gD1C2019DataSet4
            // 
            this.gD1C2019DataSet4.DataSetName = "GD1C2019DataSet4";
            this.gD1C2019DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarecorridosBindingSource
            // 
            this.listarecorridosBindingSource.DataMember = "lista_recorridos";
            this.listarecorridosBindingSource.DataSource = this.gD1C2019DataSet4;
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
            this.Seleccion.Text = "Modificar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox_solo_no_activos);
            this.groupBox1.Controls.Add(this.checkBox_solo_activos);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox_solo_activos
            // 
            this.checkBox_solo_activos.AutoSize = true;
            this.checkBox_solo_activos.Location = new System.Drawing.Point(345, 77);
            this.checkBox_solo_activos.Name = "checkBox_solo_activos";
            this.checkBox_solo_activos.Size = new System.Drawing.Size(61, 17);
            this.checkBox_solo_activos.TabIndex = 2;
            this.checkBox_solo_activos.Text = "Activos";
            this.checkBox_solo_activos.UseVisualStyleBackColor = true;
            // 
            // checkBox_solo_no_activos
            // 
            this.checkBox_solo_no_activos.AutoSize = true;
            this.checkBox_solo_no_activos.Location = new System.Drawing.Point(345, 54);
            this.checkBox_solo_no_activos.Name = "checkBox_solo_no_activos";
            this.checkBox_solo_no_activos.Size = new System.Drawing.Size(77, 17);
            this.checkBox_solo_no_activos.TabIndex = 3;
            this.checkBox_solo_no_activos.Text = "No activos";
            this.checkBox_solo_no_activos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puerto Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puerto Origen";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(345, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(567, 338);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // ModificacionRecorridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 373);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificacionRecorridos";
            this.Text = "ModificacionRecorridos";
            this.Load += new System.EventHandler(this.ModificacionRecorridos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarecorridosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet4 gD1C2019DataSet4;
        private System.Windows.Forms.BindingSource listarecorridosBindingSource;
        private GD1C2019DataSet4TableAdapters.lista_recorridosTableAdapter lista_recorridosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGORECORRIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTOORIGENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTODESTINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOBASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTADODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_solo_no_activos;
        private System.Windows.Forms.CheckBox checkBox_solo_activos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_salir;
    }
}