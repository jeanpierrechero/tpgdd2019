namespace FrbaCrucero.AbmCrucero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_entrar_baja_cruceros = new System.Windows.Forms.Button();
            this.button_entrar_modificacion_cruceros = new System.Windows.Forms.Button();
            this.button_entrar_alta_crucero = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_entrar_baja_cruceros);
            this.groupBox1.Controls.Add(this.button_entrar_modificacion_cruceros);
            this.groupBox1.Controls.Add(this.button_entrar_alta_crucero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion De Cruceros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eliminar Crucero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modificar Crucero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nuevo Crucero";
            // 
            // button_entrar_baja_cruceros
            // 
            this.button_entrar_baja_cruceros.Location = new System.Drawing.Point(124, 114);
            this.button_entrar_baja_cruceros.Name = "button_entrar_baja_cruceros";
            this.button_entrar_baja_cruceros.Size = new System.Drawing.Size(75, 23);
            this.button_entrar_baja_cruceros.TabIndex = 2;
            this.button_entrar_baja_cruceros.Text = "Entrar";
            this.button_entrar_baja_cruceros.UseVisualStyleBackColor = true;
            this.button_entrar_baja_cruceros.Click += new System.EventHandler(this.button_entrar_baja_cruceros_Click);
            // 
            // button_entrar_modificacion_cruceros
            // 
            this.button_entrar_modificacion_cruceros.Location = new System.Drawing.Point(124, 72);
            this.button_entrar_modificacion_cruceros.Name = "button_entrar_modificacion_cruceros";
            this.button_entrar_modificacion_cruceros.Size = new System.Drawing.Size(75, 23);
            this.button_entrar_modificacion_cruceros.TabIndex = 1;
            this.button_entrar_modificacion_cruceros.Text = "Entrar";
            this.button_entrar_modificacion_cruceros.UseVisualStyleBackColor = true;
            // 
            // button_entrar_alta_crucero
            // 
            this.button_entrar_alta_crucero.Location = new System.Drawing.Point(124, 31);
            this.button_entrar_alta_crucero.Name = "button_entrar_alta_crucero";
            this.button_entrar_alta_crucero.Size = new System.Drawing.Size(75, 23);
            this.button_entrar_alta_crucero.TabIndex = 0;
            this.button_entrar_alta_crucero.Text = "Entrar";
            this.button_entrar_alta_crucero.UseVisualStyleBackColor = true;
            this.button_entrar_alta_crucero.Click += new System.EventHandler(this.button_entrar_alta_crucero_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(260, 226);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 1;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(12, 226);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 2;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_entrar_baja_cruceros;
        private System.Windows.Forms.Button button_entrar_modificacion_cruceros;
        private System.Windows.Forms.Button button_entrar_alta_crucero;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_volver;
    }
}