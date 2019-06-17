namespace FrbaCrucero.AbmRol
{
    partial class BajaRoles
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listaRolesDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet1 = new FrbaCrucero.GD1C2019DataSet();
            this.listaRolesDisponiblesTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.listaRolesDisponiblesTableAdapter();
            this.listaRolesActivos = new FrbaCrucero.listaRolesActivos();
            this.listaRolesDisponiblesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesDisponiblesTableAdapter1 = new FrbaCrucero.listaRolesActivosTableAdapters.listaRolesDisponiblesTableAdapter();
            this.listaRolesDisponiblesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button_buscar);
            this.groupBox.Controls.Add(this.textBox_nombre);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(438, 70);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filtro de Busqueda";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(201, 22);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(66, 24);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn,
            this.fUNCIONALIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewCheckBoxColumn,
            this.Seleccion});
            this.dataGridView2.DataSource = this.listaRolesDisponiblesBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(438, 260);
            this.dataGridView2.TabIndex = 1;
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
            this.Seleccion.Text = "Borrar";
            // 
            // listaRolesDisponiblesBindingSource
            // 
            this.listaRolesDisponiblesBindingSource.DataMember = "listaRolesDisponibles";
            this.listaRolesDisponiblesBindingSource.DataSource = this.gD1C2019DataSet1;
            // 
            // gD1C2019DataSet1
            // 
            this.gD1C2019DataSet1.DataSetName = "GD1C2019DataSet";
            this.gD1C2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesDisponiblesTableAdapter
            // 
            this.listaRolesDisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // listaRolesActivos
            // 
            this.listaRolesActivos.DataSetName = "listaRolesActivos";
            this.listaRolesActivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesDisponiblesBindingSource1
            // 
            this.listaRolesDisponiblesBindingSource1.DataMember = "listaRolesDisponibles";
            this.listaRolesDisponiblesBindingSource1.DataSource = this.listaRolesActivos;
            // 
            // listaRolesDisponiblesTableAdapter1
            // 
            this.listaRolesDisponiblesTableAdapter1.ClearBeforeFill = true;
            // 
            // listaRolesDisponiblesBindingSource2
            // 
            this.listaRolesDisponiblesBindingSource2.DataMember = "listaRolesDisponibles";
            this.listaRolesDisponiblesBindingSource2.DataSource = this.listaRolesActivos;
            // 
            // BajaRoles
            // 
            this.ClientSize = new System.Drawing.Size(462, 360);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox);
            this.Name = "BajaRoles";
            this.Text = "Baja Roles";
            this.Load += new System.EventHandler(this.BajaRoles_Load_1);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesDisponiblesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_filtro_por_nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource listaRolesBindingSource;
        private GD1C2019DataSetTableAdapters.listaRolesDisponiblesTableAdapter listaRolesTableAdapter;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolenombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roleactivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion_boton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GD1C2019DataSet gD1C2019DataSet1;
        private System.Windows.Forms.BindingSource listaRolesDisponiblesBindingSource;
        private GD1C2019DataSetTableAdapters.listaRolesDisponiblesTableAdapter listaRolesDisponiblesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCIONALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTADODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private listaRolesActivos listaRolesActivos;
        private System.Windows.Forms.BindingSource listaRolesDisponiblesBindingSource1;
        private listaRolesActivosTableAdapters.listaRolesDisponiblesTableAdapter listaRolesDisponiblesTableAdapter1;
        private System.Windows.Forms.BindingSource listaRolesDisponiblesBindingSource2;
    }
}