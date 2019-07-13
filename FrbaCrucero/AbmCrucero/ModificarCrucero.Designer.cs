namespace FrbaCrucero.AbmCrucero
{
    partial class ModificarCrucero
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaCruceros = new FrbaCrucero.listaCruceros();
            this.listaCrucerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCrucerosTableAdapter = new FrbaCrucero.listaCrucerosTableAdapters.listaCrucerosTableAdapter();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAALTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHABAJADEFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxModelos = new System.Windows.Forms.ComboBox();
            this.comboBoxFabricantes = new System.Windows.Forms.ComboBox();
            this.checkBoxActivos = new System.Windows.Forms.CheckBox();
            this.checkBox_Inactivos = new System.Windows.Forms.CheckBox();
            this.fecha_alta_crucero = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listaModelos = new FrbaCrucero.listaModelos();
            this.listaModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaModeloTableAdapter = new FrbaCrucero.listaModelosTableAdapters.listaModeloTableAdapter();
            this.listaFabricante = new FrbaCrucero.listaFabricante();
            this.listaFabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFabricanteTableAdapter = new FrbaCrucero.listaFabricanteTableAdapters.listaFabricanteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCruceros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fecha_alta_crucero);
            this.groupBox1.Controls.Add(this.checkBox_Inactivos);
            this.groupBox1.Controls.Add(this.checkBoxActivos);
            this.groupBox1.Controls.Add(this.comboBoxFabricantes);
            this.groupBox1.Controls.Add(this.comboBoxModelos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.mODELODataGridViewTextBoxColumn,
            this.fABRICANTEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.fECHAALTADataGridViewTextBoxColumn,
            this.fECHABAJADEFDataGridViewCheckBoxColumn,
            this.Modificar});
            this.dataGridView1.DataSource = this.listaCrucerosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // listaCruceros
            // 
            this.listaCruceros.DataSetName = "listaCruceros";
            this.listaCruceros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaCrucerosBindingSource
            // 
            this.listaCrucerosBindingSource.DataMember = "listaCruceros";
            this.listaCrucerosBindingSource.DataSource = this.listaCruceros;
            // 
            // listaCrucerosTableAdapter
            // 
            this.listaCrucerosTableAdapter.ClearBeforeFill = true;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            // 
            // fABRICANTEDataGridViewTextBoxColumn
            // 
            this.fABRICANTEDataGridViewTextBoxColumn.DataPropertyName = "FABRICANTE";
            this.fABRICANTEDataGridViewTextBoxColumn.HeaderText = "FABRICANTE";
            this.fABRICANTEDataGridViewTextBoxColumn.Name = "fABRICANTEDataGridViewTextBoxColumn";
            this.fABRICANTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAALTADataGridViewTextBoxColumn
            // 
            this.fECHAALTADataGridViewTextBoxColumn.DataPropertyName = "FECHA_ALTA";
            this.fECHAALTADataGridViewTextBoxColumn.HeaderText = "FECHA_ALTA";
            this.fECHAALTADataGridViewTextBoxColumn.Name = "fECHAALTADataGridViewTextBoxColumn";
            // 
            // fECHABAJADEFDataGridViewCheckBoxColumn
            // 
            this.fECHABAJADEFDataGridViewCheckBoxColumn.DataPropertyName = "FECHA_BAJA_DEF";
            this.fECHABAJADEFDataGridViewCheckBoxColumn.HeaderText = "FECHA_BAJA_DEF";
            this.fECHABAJADEFDataGridViewCheckBoxColumn.Name = "fECHABAJADEFDataGridViewCheckBoxColumn";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Seleccion";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Alta";
            // 
            // comboBoxModelos
            // 
            this.comboBoxModelos.DataSource = this.listaModeloBindingSource;
            this.comboBoxModelos.FormattingEnabled = true;
            this.comboBoxModelos.Location = new System.Drawing.Point(79, 24);
            this.comboBoxModelos.Name = "comboBoxModelos";
            this.comboBoxModelos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModelos.TabIndex = 2;
            // 
            // comboBoxFabricantes
            // 
            this.comboBoxFabricantes.DataSource = this.listaFabricanteBindingSource;
            this.comboBoxFabricantes.FormattingEnabled = true;
            this.comboBoxFabricantes.Location = new System.Drawing.Point(79, 53);
            this.comboBoxFabricantes.Name = "comboBoxFabricantes";
            this.comboBoxFabricantes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFabricantes.TabIndex = 4;
            // 
            // checkBoxActivos
            // 
            this.checkBoxActivos.AutoSize = true;
            this.checkBoxActivos.Location = new System.Drawing.Point(319, 24);
            this.checkBoxActivos.Name = "checkBoxActivos";
            this.checkBoxActivos.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActivos.TabIndex = 5;
            this.checkBoxActivos.Text = "Activo";
            this.checkBoxActivos.UseVisualStyleBackColor = true;
            // 
            // checkBox_Inactivos
            // 
            this.checkBox_Inactivos.AutoSize = true;
            this.checkBox_Inactivos.Location = new System.Drawing.Point(423, 23);
            this.checkBox_Inactivos.Name = "checkBox_Inactivos";
            this.checkBox_Inactivos.Size = new System.Drawing.Size(64, 17);
            this.checkBox_Inactivos.TabIndex = 6;
            this.checkBox_Inactivos.Text = "Inactivo";
            this.checkBox_Inactivos.UseVisualStyleBackColor = true;
            // 
            // fecha_alta_crucero
            // 
            this.fecha_alta_crucero.Location = new System.Drawing.Point(319, 50);
            this.fecha_alta_crucero.Name = "fecha_alta_crucero";
            this.fecha_alta_crucero.Size = new System.Drawing.Size(200, 20);
            this.fecha_alta_crucero.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listaModelos
            // 
            this.listaModelos.DataSetName = "listaModelos";
            this.listaModelos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaModeloBindingSource
            // 
            this.listaModeloBindingSource.DataMember = "listaModelo";
            this.listaModeloBindingSource.DataSource = this.listaModelos;
            // 
            // listaModeloTableAdapter
            // 
            this.listaModeloTableAdapter.ClearBeforeFill = true;
            // 
            // listaFabricante
            // 
            this.listaFabricante.DataSetName = "listaFabricante";
            this.listaFabricante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaFabricanteBindingSource
            // 
            this.listaFabricanteBindingSource.DataMember = "listaFabricante";
            this.listaFabricanteBindingSource.DataSource = this.listaFabricante;
            // 
            // listaFabricanteTableAdapter
            // 
            this.listaFabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // ModificarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarCrucero";
            this.Text = "ModificarCrucero";
            this.Load += new System.EventHandler(this.ModificarCrucero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCruceros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private listaCruceros listaCruceros;
        private System.Windows.Forms.BindingSource listaCrucerosBindingSource;
        private listaCrucerosTableAdapters.listaCrucerosTableAdapter listaCrucerosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fABRICANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fECHABAJADEFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha_alta_crucero;
        private System.Windows.Forms.CheckBox checkBox_Inactivos;
        private System.Windows.Forms.CheckBox checkBoxActivos;
        private System.Windows.Forms.ComboBox comboBoxFabricantes;
        private System.Windows.Forms.ComboBox comboBoxModelos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private listaModelos listaModelos;
        private System.Windows.Forms.BindingSource listaModeloBindingSource;
        private listaModelosTableAdapters.listaModeloTableAdapter listaModeloTableAdapter;
        private listaFabricante listaFabricante;
        private System.Windows.Forms.BindingSource listaFabricanteBindingSource;
        private listaFabricanteTableAdapters.listaFabricanteTableAdapter listaFabricanteTableAdapter;
    }
}