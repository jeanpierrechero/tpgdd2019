namespace FrbaCrucero.AbmCrucero
{
    partial class ConfirmacionCancelacionPasajes
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_rechazar = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿ Desea cancelar los pasajes ?";
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(94, 90);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 1;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_rechazar
            // 
            this.button_rechazar.Location = new System.Drawing.Point(94, 136);
            this.button_rechazar.Name = "button_rechazar";
            this.button_rechazar.Size = new System.Drawing.Size(75, 23);
            this.button_rechazar.TabIndex = 2;
            this.button_rechazar.Text = "Rechazar";
            this.button_rechazar.UseVisualStyleBackColor = true;
            this.button_rechazar.Click += new System.EventHandler(this.button_rechazar_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(12, 226);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 3;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // ConfirmacionCancelacionPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_rechazar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmacionCancelacionPasajes";
            this.Text = "ConfirmacionCancelacionPasajes";
            this.Load += new System.EventHandler(this.ConfirmacionCancelacionPasajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_rechazar;
        private System.Windows.Forms.Button button_salir;
    }
}