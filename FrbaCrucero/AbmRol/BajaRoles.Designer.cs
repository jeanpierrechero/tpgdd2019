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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_filtro_por_nombre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.listaRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.listaRolesTableAdapter();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.rolenombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleactivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccion_boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_filtro_por_nombre);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_filtro_por_nombre
            // 
            this.button_filtro_por_nombre.Location = new System.Drawing.Point(242, 26);
            this.button_filtro_por_nombre.Name = "button_filtro_por_nombre";
            this.button_filtro_por_nombre.Size = new System.Drawing.Size(75, 23);
            this.button_filtro_por_nombre.TabIndex = 2;
            this.button_filtro_por_nombre.Text = "Seleccionar";
            this.button_filtro_por_nombre.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolenombreDataGridViewTextBoxColumn,
            this.funcnombreDataGridViewTextBoxColumn,
            this.roleactivoDataGridViewCheckBoxColumn,
            this.Seleccion_boton});
            this.dataGridView1.DataSource = this.listaRolesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 203);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gD1C2019DataSet
            // 
            this.gD1C2019DataSet.DataSetName = "GD1C2019DataSet";
            this.gD1C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesBindingSource
            // 
            this.listaRolesBindingSource.DataMember = "listaRoles";
            this.listaRolesBindingSource.DataSource = this.gD1C2019DataSet;
            // 
            // listaRolesTableAdapter
            // 
            this.listaRolesTableAdapter.ClearBeforeFill = true;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(21, 324);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 3;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(375, 324);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 4;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // rolenombreDataGridViewTextBoxColumn
            // 
            this.rolenombreDataGridViewTextBoxColumn.DataPropertyName = "role_nombre";
            this.rolenombreDataGridViewTextBoxColumn.HeaderText = "role_nombre";
            this.rolenombreDataGridViewTextBoxColumn.Name = "rolenombreDataGridViewTextBoxColumn";
            // 
            // funcnombreDataGridViewTextBoxColumn
            // 
            this.funcnombreDataGridViewTextBoxColumn.DataPropertyName = "func_nombre";
            this.funcnombreDataGridViewTextBoxColumn.HeaderText = "func_nombre";
            this.funcnombreDataGridViewTextBoxColumn.Name = "funcnombreDataGridViewTextBoxColumn";
            // 
            // roleactivoDataGridViewCheckBoxColumn
            // 
            this.roleactivoDataGridViewCheckBoxColumn.DataPropertyName = "role_activo";
            this.roleactivoDataGridViewCheckBoxColumn.HeaderText = "role_activo";
            this.roleactivoDataGridViewCheckBoxColumn.Name = "roleactivoDataGridViewCheckBoxColumn";
            // 
            // Seleccion_boton
            // 
            this.Seleccion_boton.HeaderText = "Seleccion";
            this.Seleccion_boton.Name = "Seleccion_boton";
            this.Seleccion_boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccion_boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion_boton.Text = "Seleccionar";
            // 
            // BajaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaRoles";
            this.Text = "BajaRoles";
            this.Load += new System.EventHandler(this.BajaRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource)).EndInit();
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
        private GD1C2019DataSetTableAdapters.listaRolesTableAdapter listaRolesTableAdapter;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolenombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roleactivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion_boton;
    }
}