namespace FrbaCrucero.AbmCrucero
{
    partial class BajaCrucero
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
            this.gD1C2019DataSet7 = new FrbaCrucero.GD1C2019DataSet7();
            this.listaCrucerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCrucerosTableAdapter = new FrbaCrucero.GD1C2019DataSet7TableAdapters.listaCrucerosTableAdapter();
            this.gD1C2019DataSet8 = new FrbaCrucero.GD1C2019DataSet8();
            this.listaCrucerosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCrucerosDisponiblesTableAdapter = new FrbaCrucero.GD1C2019DataSet8TableAdapters.listaCrucerosDisponiblesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2019DataSet9 = new FrbaCrucero.GD1C2019DataSet9();
            this.listaCrucerosDisponiblesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaCrucerosDisponiblesTableAdapter1 = new FrbaCrucero.GD1C2019DataSet9TableAdapters.listaCrucerosDisponiblesTableAdapter();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAALTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHABAJATEMPORALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_buscar_con_parametros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponiblesBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gD1C2019DataSet7
            // 
            this.gD1C2019DataSet7.DataSetName = "GD1C2019DataSet7";
            this.gD1C2019DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaCrucerosBindingSource
            // 
            this.listaCrucerosBindingSource.DataMember = "listaCruceros";
            this.listaCrucerosBindingSource.DataSource = this.gD1C2019DataSet7;
            // 
            // listaCrucerosTableAdapter
            // 
            this.listaCrucerosTableAdapter.ClearBeforeFill = true;
            // 
            // gD1C2019DataSet8
            // 
            this.gD1C2019DataSet8.DataSetName = "GD1C2019DataSet8";
            this.gD1C2019DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaCrucerosDisponiblesBindingSource
            // 
            this.listaCrucerosDisponiblesBindingSource.DataMember = "listaCrucerosDisponibles";
            this.listaCrucerosDisponiblesBindingSource.DataSource = this.gD1C2019DataSet8;
            // 
            // listaCrucerosDisponiblesTableAdapter
            // 
            this.listaCrucerosDisponiblesTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.listaCrucerosDisponiblesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // gD1C2019DataSet9
            // 
            this.gD1C2019DataSet9.DataSetName = "GD1C2019DataSet9";
            this.gD1C2019DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaCrucerosDisponiblesBindingSource1
            // 
            this.listaCrucerosDisponiblesBindingSource1.DataMember = "listaCrucerosDisponibles";
            this.listaCrucerosDisponiblesBindingSource1.DataSource = this.gD1C2019DataSet9;
            // 
            // listaCrucerosDisponiblesTableAdapter1
            // 
            this.listaCrucerosDisponiblesTableAdapter1.ClearBeforeFill = true;
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
            this.Seleccion.Text = "Eliminar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_buscar_con_parametros);
            this.groupBox1.Controls.Add(this.button_limpiar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja Crucero";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(93, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(93, 107);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(9, 149);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 12;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(658, 423);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 13;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(21, 423);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 14;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            // 
            // button_buscar_con_parametros
            // 
            this.button_buscar_con_parametros.Location = new System.Drawing.Point(640, 149);
            this.button_buscar_con_parametros.Name = "button_buscar_con_parametros";
            this.button_buscar_con_parametros.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_con_parametros.TabIndex = 13;
            this.button_buscar_con_parametros.Text = "Buscar";
            this.button_buscar_con_parametros.UseVisualStyleBackColor = true;
            // 
            // BajaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 458);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BajaCrucero";
            this.Text = "BajaCrucero";
            this.Load += new System.EventHandler(this.BajaCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCrucerosDisponiblesBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GD1C2019DataSet7 gD1C2019DataSet7;
        private System.Windows.Forms.BindingSource listaCrucerosBindingSource;
        private GD1C2019DataSet7TableAdapters.listaCrucerosTableAdapter listaCrucerosTableAdapter;
        private GD1C2019DataSet8 gD1C2019DataSet8;
        private System.Windows.Forms.BindingSource listaCrucerosDisponiblesBindingSource;
        private GD1C2019DataSet8TableAdapters.listaCrucerosDisponiblesTableAdapter listaCrucerosDisponiblesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet9 gD1C2019DataSet9;
        private System.Windows.Forms.BindingSource listaCrucerosDisponiblesBindingSource1;
        private GD1C2019DataSet9TableAdapters.listaCrucerosDisponiblesTableAdapter listaCrucerosDisponiblesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fABRICANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHABAJATEMPORALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_buscar_con_parametros;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_volver;
    }
}