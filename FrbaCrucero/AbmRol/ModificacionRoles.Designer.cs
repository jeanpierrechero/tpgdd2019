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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2019DataSet3 = new FrbaCrucero.GD1C2019DataSet3();
            this.listaRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaRolesTableAdapter = new FrbaCrucero.GD1C2019DataSet3TableAdapters.listaRolesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.rolenombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleactivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_solo_activos = new System.Windows.Forms.CheckBox();
            this.checkBox_solo_no_activos = new System.Windows.Forms.CheckBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_solo_no_activos);
            this.groupBox1.Controls.Add(this.checkBox_solo_activos);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolenombreDataGridViewTextBoxColumn,
            this.funcnombreDataGridViewTextBoxColumn,
            this.roleactivoDataGridViewCheckBoxColumn,
            this.Seleccion});
            this.dataGridView1.DataSource = this.listaRolesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 163);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gD1C2019DataSet3
            // 
            this.gD1C2019DataSet3.DataSetName = "GD1C2019DataSet3";
            this.gD1C2019DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaRolesBindingSource
            // 
            this.listaRolesBindingSource.DataMember = "listaRoles";
            this.listaRolesBindingSource.DataSource = this.gD1C2019DataSet3;
            // 
            // listaRolesTableAdapter
            // 
            this.listaRolesTableAdapter.ClearBeforeFill = true;
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
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Text = "Modificar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox_solo_activos
            // 
            this.checkBox_solo_activos.AutoSize = true;
            this.checkBox_solo_activos.Location = new System.Drawing.Point(241, 28);
            this.checkBox_solo_activos.Name = "checkBox_solo_activos";
            this.checkBox_solo_activos.Size = new System.Drawing.Size(61, 17);
            this.checkBox_solo_activos.TabIndex = 3;
            this.checkBox_solo_activos.Text = "Activos";
            this.checkBox_solo_activos.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet3 gD1C2019DataSet3;
        private System.Windows.Forms.BindingSource listaRolesBindingSource;
        private GD1C2019DataSet3TableAdapters.listaRolesTableAdapter listaRolesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_solo_no_activos;
        private System.Windows.Forms.CheckBox checkBox_solo_activos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolenombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roleactivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.Button button_salir;
    }
}