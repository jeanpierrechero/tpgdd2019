namespace FrbaCrucero.AbmRol
{
    partial class Form1
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
            this.boton_volver_roles = new System.Windows.Forms.Button();
            this.boton_baja_rol = new System.Windows.Forms.Button();
            this.boton_modif_rol = new System.Windows.Forms.Button();
            this.boton_alta_rol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_volver_roles
            // 
            this.boton_volver_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.boton_volver_roles.Location = new System.Drawing.Point(12, 226);
            this.boton_volver_roles.Name = "boton_volver_roles";
            this.boton_volver_roles.Size = new System.Drawing.Size(75, 23);
            this.boton_volver_roles.TabIndex = 9;
            this.boton_volver_roles.Text = "Volver";
            this.boton_volver_roles.UseVisualStyleBackColor = true;
            this.boton_volver_roles.Click += new System.EventHandler(this.boton_volver_roles_Click);
            // 
            // boton_baja_rol
            // 
            this.boton_baja_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.boton_baja_rol.Location = new System.Drawing.Point(132, 109);
            this.boton_baja_rol.Name = "boton_baja_rol";
            this.boton_baja_rol.Size = new System.Drawing.Size(96, 23);
            this.boton_baja_rol.TabIndex = 8;
            this.boton_baja_rol.Text = "Entrar";
            this.boton_baja_rol.UseVisualStyleBackColor = true;
            this.boton_baja_rol.Click += new System.EventHandler(this.boton_baja_rol_Click);
            // 
            // boton_modif_rol
            // 
            this.boton_modif_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.boton_modif_rol.Location = new System.Drawing.Point(132, 75);
            this.boton_modif_rol.Name = "boton_modif_rol";
            this.boton_modif_rol.Size = new System.Drawing.Size(96, 23);
            this.boton_modif_rol.TabIndex = 7;
            this.boton_modif_rol.Text = "Entrar";
            this.boton_modif_rol.UseVisualStyleBackColor = true;
            this.boton_modif_rol.Click += new System.EventHandler(this.boton_modif_rol_Click);
            // 
            // boton_alta_rol
            // 
            this.boton_alta_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.boton_alta_rol.Location = new System.Drawing.Point(132, 42);
            this.boton_alta_rol.Name = "boton_alta_rol";
            this.boton_alta_rol.Size = new System.Drawing.Size(96, 23);
            this.boton_alta_rol.TabIndex = 6;
            this.boton_alta_rol.Text = "Entrar";
            this.boton_alta_rol.UseVisualStyleBackColor = true;
            this.boton_alta_rol.Click += new System.EventHandler(this.boton_alta_rol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boton_alta_rol);
            this.groupBox1.Controls.Add(this.boton_baja_rol);
            this.groupBox1.Controls.Add(this.boton_modif_rol);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de Roles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Eliminar un Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modificar un Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Crear un Rol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_volver_roles);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_volver_roles;
        private System.Windows.Forms.Button boton_baja_rol;
        private System.Windows.Forms.Button boton_modif_rol;
        private System.Windows.Forms.Button boton_alta_rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}