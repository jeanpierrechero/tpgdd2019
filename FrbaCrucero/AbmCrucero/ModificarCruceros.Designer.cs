namespace FrbaCrucero.AbmCrucero
{
    partial class ModificarCruceros
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
            this.button_volver = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_buscar_con_parametros = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.comboBox_modelo = new System.Windows.Forms.ComboBox();
            this.comboBox_fabricante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaCrucerosDisponibles = new FrbaCrucero.listaCrucerosDisponibles();
            this.listaCrucerosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCrucerosDisponiblesTableAdapter = new FrbaCrucero.listaCrucerosDisponiblesTableAdapters.listaCrucerosDisponiblesTableAdapter();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAALTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHABAJATEMPORALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listaFabricantesParaCombobox = new FrbaCrucero.listaFabricantesParaCombobox();
            this.listaFabricantesParaComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFabricanteTableAdapter = new FrbaCrucero.listaFabricantesParaComboboxTableAdapters.listaFabricanteTableAdapter();
            this.listaModelosComboBox = new FrbaCrucero.listaModelosComboBox();
            this.listaModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaModeloTableAdapter = new FrbaCrucero.listaModelosComboBoxTableAdapters.listaModeloTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(12, 447);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 18;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(684, 447);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 17;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_buscar_con_parametros);
            this.groupBox1.Controls.Add(this.button_limpiar);
            this.groupBox1.Controls.Add(this.textBox_codigo);
            this.groupBox1.Controls.Add(this.comboBox_modelo);
            this.groupBox1.Controls.Add(this.comboBox_fabricante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 178);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja Crucero";
            // 
            // button_buscar_con_parametros
            // 
            this.button_buscar_con_parametros.Location = new System.Drawing.Point(232, 149);
            this.button_buscar_con_parametros.Name = "button_buscar_con_parametros";
            this.button_buscar_con_parametros.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_con_parametros.TabIndex = 13;
            this.button_buscar_con_parametros.Text = "Buscar";
            this.button_buscar_con_parametros.UseVisualStyleBackColor = true;
            this.button_buscar_con_parametros.Click += new System.EventHandler(this.button_buscar_con_parametros_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(9, 149);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 12;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(93, 30);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(121, 20);
            this.textBox_codigo.TabIndex = 8;
            this.textBox_codigo.TextChanged += new System.EventHandler(this.textBox_codigo_TextChanged);
            // 
            // comboBox_modelo
            // 
            this.comboBox_modelo.DataSource = this.listaModeloBindingSource;
            this.comboBox_modelo.FormattingEnabled = true;
            this.comboBox_modelo.Location = new System.Drawing.Point(93, 107);
            this.comboBox_modelo.Name = "comboBox_modelo";
            this.comboBox_modelo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_modelo.TabIndex = 7;
            this.comboBox_modelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_modelo_SelectedIndexChanged);
            // 
            // comboBox_fabricante
            // 
            this.comboBox_fabricante.DataSource = this.listaFabricanteBindingSource;
            this.comboBox_fabricante.FormattingEnabled = true;
            this.comboBox_fabricante.Location = new System.Drawing.Point(93, 70);
            this.comboBox_fabricante.Name = "comboBox_fabricante";
            this.comboBox_fabricante.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fabricante.TabIndex = 6;
            this.comboBox_fabricante.SelectedIndexChanged += new System.EventHandler(this.comboBox_fabricante_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
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
            this.fECHABAJATEMPORALDataGridViewTextBoxColumn,
            this.Seleccion});
            this.dataGridView1.DataSource = this.listaCrucerosDisponiblesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 204);
            this.dataGridView1.TabIndex = 15;
            // 
            // listaCrucerosDisponibles
            // 
            this.listaCrucerosDisponibles.DataSetName = "listaCrucerosDisponibles";
            this.listaCrucerosDisponibles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaCrucerosDisponiblesBindingSource
            // 
            this.listaCrucerosDisponiblesBindingSource.DataMember = "listaCrucerosDisponibles";
            this.listaCrucerosDisponiblesBindingSource.DataSource = this.listaCrucerosDisponibles;
            // 
            // listaCrucerosDisponiblesTableAdapter
            // 
            this.listaCrucerosDisponiblesTableAdapter.ClearBeforeFill = true;
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
            // fECHABAJATEMPORALDataGridViewTextBoxColumn
            // 
            this.fECHABAJATEMPORALDataGridViewTextBoxColumn.DataPropertyName = "FECHA_BAJA_TEMPORAL";
            this.fECHABAJATEMPORALDataGridViewTextBoxColumn.HeaderText = "FECHA_BAJA_TEMPORAL";
            this.fECHABAJATEMPORALDataGridViewTextBoxColumn.Name = "fECHABAJATEMPORALDataGridViewTextBoxColumn";
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Text = "Modificar";
            // 
            // listaFabricantesParaCombobox
            // 
            this.listaFabricantesParaCombobox.DataSetName = "listaFabricantesParaCombobox";
            this.listaFabricantesParaCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaFabricantesParaComboboxBindingSource
            // 
            this.listaFabricantesParaComboboxBindingSource.DataSource = this.listaFabricantesParaCombobox;
            this.listaFabricantesParaComboboxBindingSource.Position = 0;
            // 
            // listaFabricanteBindingSource
            // 
            this.listaFabricanteBindingSource.DataMember = "listaFabricante";
            this.listaFabricanteBindingSource.DataSource = this.listaFabricantesParaComboboxBindingSource;
            // 
            // listaFabricanteTableAdapter
            // 
            this.listaFabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // listaModelosComboBox
            // 
            this.listaModelosComboBox.DataSetName = "listaModelosComboBox";
            this.listaModelosComboBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaModeloBindingSource
            // 
            this.listaModeloBindingSource.DataMember = "listaModelo";
            this.listaModeloBindingSource.DataSource = this.listaModelosComboBox;
            // 
            // listaModeloTableAdapter
            // 
            this.listaModeloTableAdapter.ClearBeforeFill = true;
            // 
            // ModificarCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 482);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarCruceros";
            this.Text = "ModificarCruceros";
            this.Load += new System.EventHandler(this.ModificarCruceros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_buscar_con_parametros;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.ComboBox comboBox_modelo;
        private System.Windows.Forms.ComboBox comboBox_fabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private listaCrucerosDisponibles listaCrucerosDisponibles;
        private System.Windows.Forms.BindingSource listaCrucerosDisponiblesBindingSource;
        private listaCrucerosDisponiblesTableAdapters.listaCrucerosDisponiblesTableAdapter listaCrucerosDisponiblesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fABRICANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHABAJATEMPORALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.BindingSource listaFabricantesParaComboboxBindingSource;
        private listaFabricantesParaCombobox listaFabricantesParaCombobox;
        private System.Windows.Forms.BindingSource listaFabricanteBindingSource;
        private listaFabricantesParaComboboxTableAdapters.listaFabricanteTableAdapter listaFabricanteTableAdapter;
        private listaModelosComboBox listaModelosComboBox;
        private System.Windows.Forms.BindingSource listaModeloBindingSource;
        private listaModelosComboBoxTableAdapters.listaModeloTableAdapter listaModeloTableAdapter;
    }
}