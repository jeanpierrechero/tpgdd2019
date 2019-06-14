namespace FrbaCrucero.AbmRecorrido
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
            this.button_volver = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_entrar_alta_recorrido = new System.Windows.Forms.Button();
            this.button_entrar_modif_recorrido = new System.Windows.Forms.Button();
            this.button_entrar_eliminar_recorrido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_entrar_eliminar_recorrido);
            this.groupBox1.Controls.Add(this.button_entrar_modif_recorrido);
            this.groupBox1.Controls.Add(this.button_entrar_alta_recorrido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de Recorridos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(13, 226);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 1;
            this.button_volver.Text = "Voler";
            this.button_volver.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(207, 226);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Recorrido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modificar Recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eliminar Recorrido";
            // 
            // button_entrar_alta_recorrido
            // 
            this.button_entrar_alta_recorrido.Location = new System.Drawing.Point(140, 38);
            this.button_entrar_alta_recorrido.Name = "button_entrar_alta_recorrido";
            this.button_entrar_alta_recorrido.Size = new System.Drawing.Size(75, 23);
            this.button_entrar_alta_recorrido.TabIndex = 3;
            this.button_entrar_alta_recorrido.Text = "Entrar";
            this.button_entrar_alta_recorrido.UseVisualStyleBackColor = true;
            // 
            // button_entrar_modif_recorrido
            // 
            this.button_entrar_modif_recorrido.Location = new System.Drawing.Point(140, 80);
            this.button_entrar_modif_recorrido.Name = "button_entrar_modif_recorrido";
            this.button_entrar_modif_recorrido.Size = new System.Drawing.Size(75, 23);
            this.button_entrar_modif_recorrido.TabIndex = 4;
            this.button_entrar_modif_recorrido.Text = "Entrar";
            this.button_entrar_modif_recorrido.UseVisualStyleBackColor = true;
            // 
            // button_entrar_eliminar_recorrido
            // 
            this.button_entrar_eliminar_recorrido.Location = new System.Drawing.Point(140, 122);
            this.button_entrar_eliminar_recorrido.Name = "button_entrar_eliminar_recorrido";
            this.button_entrar_eliminar_recorrido.Size = new System.Drawing.Size(75, 23);
            this.button_entrar_eliminar_recorrido.TabIndex = 5;
            this.button_entrar_eliminar_recorrido.Text = "Entrar";
            this.button_entrar_eliminar_recorrido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_volver);
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
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_entrar_eliminar_recorrido;
        private System.Windows.Forms.Button button_entrar_modif_recorrido;
        private System.Windows.Forms.Button button_entrar_alta_recorrido;
    }
}