namespace FrbaCrucero.AbmRol
{
    partial class AltaRoles
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
            this.comboBoxSeleccionados = new System.Windows.Forms.ComboBox();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_box = new System.Windows.Forms.TextBox();
            this.comboBox_funcionalidades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSeleccionados
            // 
            this.comboBoxSeleccionados.FormattingEnabled = true;
            this.comboBoxSeleccionados.Location = new System.Drawing.Point(142, 119);
            this.comboBoxSeleccionados.Name = "comboBoxSeleccionados";
            this.comboBoxSeleccionados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeleccionados.TabIndex = 18;
            this.comboBoxSeleccionados.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeleccionados_SelectedIndexChanged);
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(288, 223);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(75, 23);
            this.boton_guardar.TabIndex = 17;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(35, 223);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 16;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Funcionalidades Asignadas";
            // 
            // nombre_box
            // 
            this.nombre_box.Location = new System.Drawing.Point(142, 31);
            this.nombre_box.Name = "nombre_box";
            this.nombre_box.Size = new System.Drawing.Size(121, 20);
            this.nombre_box.TabIndex = 14;
            this.nombre_box.TextChanged += new System.EventHandler(this.nombre_box_TextChanged);
            // 
            // comboBox_funcionalidades
            // 
            this.comboBox_funcionalidades.FormattingEnabled = true;
            this.comboBox_funcionalidades.Location = new System.Drawing.Point(142, 78);
            this.comboBox_funcionalidades.Name = "comboBox_funcionalidades";
            this.comboBox_funcionalidades.Size = new System.Drawing.Size(121, 21);
            this.comboBox_funcionalidades.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Funcionalidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSeleccionados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_funcionalidades);
            this.groupBox1.Controls.Add(this.nombre_box);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 172);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Rol";
            // 
            // AltaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 261);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaRoles";
            this.Text = "AltaRoles";
            this.Load += new System.EventHandler(this.AltaRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSeleccionados;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_box;
        private System.Windows.Forms.ComboBox comboBox_funcionalidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}