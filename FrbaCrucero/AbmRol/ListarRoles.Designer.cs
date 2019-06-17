namespace FrbaCrucero.AbmRol
{
    partial class ListarRoles
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
            this.textBox_busqueda_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listaRolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet11 = new FrbaCrucero.GD1C2019DataSet11();
            this.listaRolesTableAdapter1 = new FrbaCrucero.GD1C2019DataSet11TableAdapters.listaRolesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_busqueda_funcionalidad = new System.Windows.Forms.ComboBox();
            this.listaRolesTotal = new FrbaCrucero.listaRolesTotal();
            this.listaRolesTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesTableAdapter = new FrbaCrucero.listaRolesTotalTableAdapters.listaRolesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaRolesActivos = new FrbaCrucero.listaRolesActivos();
            this.listaRolesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesDisponiblesTableAdapter = new FrbaCrucero.listaRolesActivosTableAdapters.listaRolesDisponiblesTableAdapter();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gD1C2019DataSet12 = new FrbaCrucero.GD1C2019DataSet12();
            this.listaFuncionalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFuncionalidadesTableAdapter = new FrbaCrucero.GD1C2019DataSet12TableAdapters.listaFuncionalidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionalidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_busqueda_nombre
            // 
            this.textBox_busqueda_nombre.Location = new System.Drawing.Point(124, 43);
            this.textBox_busqueda_nombre.Name = "textBox_busqueda_nombre";
            this.textBox_busqueda_nombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_busqueda_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(413, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listaRolesBindingSource1
            // 
            this.listaRolesBindingSource1.DataMember = "listaRoles";
            this.listaRolesBindingSource1.DataSource = this.gD1C2019DataSet11;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Funcionalidad";
            // 
            // comboBox_busqueda_funcionalidad
            // 
            this.comboBox_busqueda_funcionalidad.DataSource = this.listaFuncionalidadesBindingSource;
            this.comboBox_busqueda_funcionalidad.DisplayMember = "func_nombre";
            this.comboBox_busqueda_funcionalidad.FormattingEnabled = true;
            this.comboBox_busqueda_funcionalidad.Location = new System.Drawing.Point(124, 93);
            this.comboBox_busqueda_funcionalidad.Name = "comboBox_busqueda_funcionalidad";
            this.comboBox_busqueda_funcionalidad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_busqueda_funcionalidad.TabIndex = 8;
            this.comboBox_busqueda_funcionalidad.ValueMember = "func_nombre";
            this.comboBox_busqueda_funcionalidad.SelectedIndexChanged += new System.EventHandler(this.comboBox_busqueda_funcionalidad_SelectedIndexChanged);
            // 
            // listaRolesTotal
            // 
            this.listaRolesTotal.DataSetName = "listaRolesTotal";
            this.listaRolesTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesTotalBindingSource
            // 
            this.listaRolesTotalBindingSource.DataSource = this.listaRolesTotal;
            this.listaRolesTotalBindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "listaRoles";
            this.bindingSource1.DataSource = this.listaRolesTotal;
            // 
            // listaRolesTableAdapter
            // 
            this.listaRolesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn,
            this.fUNCIONALIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.listaRolesDisponiblesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 221);
            this.dataGridView1.TabIndex = 9;
            // 
            // listaRolesActivos
            // 
            this.listaRolesActivos.DataSetName = "listaRolesActivos";
            this.listaRolesActivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesActivosBindingSource
            // 
            this.listaRolesActivosBindingSource.DataSource = this.listaRolesActivos;
            this.listaRolesActivosBindingSource.Position = 0;
            // 
            // listaRolesDisponiblesBindingSource
            // 
            this.listaRolesDisponiblesBindingSource.DataMember = "listaRolesDisponibles";
            this.listaRolesDisponiblesBindingSource.DataSource = this.listaRolesActivosBindingSource;
            // 
            // listaRolesDisponiblesTableAdapter
            // 
            this.listaRolesDisponiblesTableAdapter.ClearBeforeFill = true;
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
            // gD1C2019DataSet12
            // 
            this.gD1C2019DataSet12.DataSetName = "GD1C2019DataSet12";
            this.gD1C2019DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaFuncionalidadesBindingSource
            // 
            this.listaFuncionalidadesBindingSource.DataMember = "listaFuncionalidades";
            this.listaFuncionalidadesBindingSource.DataSource = this.gD1C2019DataSet12;
            // 
            // listaFuncionalidadesTableAdapter
            // 
            this.listaFuncionalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // ListarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_busqueda_funcionalidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_busqueda_nombre);
            this.Name = "ListarRoles";
            this.Text = "Listado de Roles";
            this.Load += new System.EventHandler(this.ListarRoles_Load);
            this.Controls.SetChildIndex(this.textBox_busqueda_nombre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox_busqueda_funcionalidad, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionalidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_busqueda_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.BindingSource listaRolesBindingSource;
       
        private GD1C2019DataSet11 gD1C2019DataSet11;
        private System.Windows.Forms.BindingSource listaRolesBindingSource1;
        private GD1C2019DataSet11TableAdapters.listaRolesTableAdapter listaRolesTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_busqueda_funcionalidad;
        private System.Windows.Forms.BindingSource listaRolesTotalBindingSource;
        private listaRolesTotal listaRolesTotal;
        private System.Windows.Forms.BindingSource bindingSource1;
        private listaRolesTotalTableAdapters.listaRolesTableAdapter listaRolesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listaRolesActivosBindingSource;
        private listaRolesActivos listaRolesActivos;
        private System.Windows.Forms.BindingSource listaRolesDisponiblesBindingSource;
        private listaRolesActivosTableAdapters.listaRolesDisponiblesTableAdapter listaRolesDisponiblesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCIONALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTADODataGridViewCheckBoxColumn;
        private GD1C2019DataSet12 gD1C2019DataSet12;
        private System.Windows.Forms.BindingSource listaFuncionalidadesBindingSource;
        private GD1C2019DataSet12TableAdapters.listaFuncionalidadesTableAdapter listaFuncionalidadesTableAdapter;
    }
}