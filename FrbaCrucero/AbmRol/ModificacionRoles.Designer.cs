namespace FrbaCrucero.AbmRol
{
    partial class ModificacionRoles
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
            this.button_buscar = new System.Windows.Forms.Button();
            this.checkBox_solo_no_activos = new System.Windows.Forms.CheckBox();
            this.checkBox_solo_activos = new System.Windows.Forms.CheckBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet3 = new FrbaCrucero.GD1C2019DataSet3();
            this.listaRolesTableAdapter = new FrbaCrucero.GD1C2019DataSet3TableAdapters.listaRolesTableAdapter();
            this.button_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listaRolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesTotal = new FrbaCrucero.listaRolesTotal();
            this.gD1C2019DataSet1 = new FrbaCrucero.GD1C2019DataSet1();
            this.gD1C2019DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet12 = new FrbaCrucero.GD1C2019DataSet12();
            this.gD1C2019DataSet11 = new FrbaCrucero.GD1C2019DataSet11();
            this.listaRolesTableAdapter1 = new FrbaCrucero.listaRolesTotalTableAdapters.listaRolesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.checkBox_solo_no_activos);
            this.groupBox1.Controls.Add(this.checkBox_solo_activos);
            this.groupBox1.Controls.Add(this.textBox_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(183, 24);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 5;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // checkBox_solo_no_activos
            // 
            this.checkBox_solo_no_activos.AutoSize = true;
            this.checkBox_solo_no_activos.Location = new System.Drawing.Point(343, 28);
            this.checkBox_solo_no_activos.Name = "checkBox_solo_no_activos";
            this.checkBox_solo_no_activos.Size = new System.Drawing.Size(77, 17);
            this.checkBox_solo_no_activos.TabIndex = 4;
            this.checkBox_solo_no_activos.Text = "No activos";
            this.checkBox_solo_no_activos.UseVisualStyleBackColor = true;
            this.checkBox_solo_no_activos.CheckedChanged += new System.EventHandler(this.checkBox_solo_no_activos_CheckedChanged);
            // 
            // checkBox_solo_activos
            // 
            this.checkBox_solo_activos.AutoSize = true;
            this.checkBox_solo_activos.Location = new System.Drawing.Point(276, 28);
            this.checkBox_solo_activos.Name = "checkBox_solo_activos";
            this.checkBox_solo_activos.Size = new System.Drawing.Size(61, 17);
            this.checkBox_solo_activos.TabIndex = 3;
            this.checkBox_solo_activos.Text = "Activos";
            this.checkBox_solo_activos.UseVisualStyleBackColor = true;
            this.checkBox_solo_activos.CheckedChanged += new System.EventHandler(this.checkBox_solo_activos_CheckedChanged);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(56, 26);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // listaRolesBindingSource
            // 
            this.listaRolesBindingSource.DataMember = "listaRoles";
            this.listaRolesBindingSource.DataSource = this.gD1C2019DataSet3;
            // 
            // gD1C2019DataSet3
            // 
            this.gD1C2019DataSet3.DataSetName = "GD1C2019DataSet3";
            this.gD1C2019DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesTableAdapter
            // 
            this.listaRolesTableAdapter.ClearBeforeFill = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(380, 260);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn,
            this.fUNCIONALIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewCheckBoxColumn,
            this.Seleccion});
            this.dataGridView1.DataSource = this.listaRolesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 163);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // fUNCIONALIDADDataGridViewTextBoxColumn
            // 
            this.fUNCIONALIDADDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fUNCIONALIDADDataGridViewTextBoxColumn.DataPropertyName = "FUNCIONALIDAD";
            this.fUNCIONALIDADDataGridViewTextBoxColumn.HeaderText = "FUNCIONALIDAD";
            this.fUNCIONALIDADDataGridViewTextBoxColumn.Name = "fUNCIONALIDADDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewCheckBoxColumn
            // 
            this.eSTADODataGridViewCheckBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewCheckBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewCheckBoxColumn.Name = "eSTADODataGridViewCheckBoxColumn";
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Text = "Modificar";
            // 
            // listaRolesBindingSource1
            // 
            this.listaRolesBindingSource1.DataMember = "listaRoles";
            this.listaRolesBindingSource1.DataSource = this.listaRolesTotal;
            // 
            // listaRolesTotal
            // 
            this.listaRolesTotal.DataSetName = "listaRolesTotal";
            this.listaRolesTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gD1C2019DataSet12
            // 
            this.gD1C2019DataSet12.DataSetName = "GD1C2019DataSet12";
            this.gD1C2019DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2019DataSet11
            // 
            this.gD1C2019DataSet11.DataSetName = "GD1C2019DataSet11";
            this.gD1C2019DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesTableAdapter1
            // 
            this.listaRolesTableAdapter1.ClearBeforeFill = true;
            // 
            // ModificacionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 295);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificacionRoles";
            this.Text = "ModificacionRoles";
            this.Load += new System.EventHandler(this.ModificacionRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GD1C2019DataSet3 gD1C2019DataSet3;
        private System.Windows.Forms.BindingSource listaRolesBindingSource;
        private GD1C2019DataSet3TableAdapters.listaRolesTableAdapter listaRolesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_solo_no_activos;
        private System.Windows.Forms.CheckBox checkBox_solo_activos;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet1 gD1C2019DataSet1;
        private System.Windows.Forms.BindingSource gD1C2019DataSet1BindingSource;
        private GD1C2019DataSet12 gD1C2019DataSet12;
        private GD1C2019DataSet11 gD1C2019DataSet11;
        private listaRolesTotal listaRolesTotal;
        private System.Windows.Forms.BindingSource listaRolesBindingSource1;
        private listaRolesTotalTableAdapters.listaRolesTableAdapter listaRolesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCIONALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTADODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.Button button_buscar;
    }
}