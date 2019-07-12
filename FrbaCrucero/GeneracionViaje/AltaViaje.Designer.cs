namespace FrbaCrucero.GeneracionViaje
{
    partial class AltaViaje
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
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_crucero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_recorrido_desde = new System.Windows.Forms.ComboBox();
            this.combo_recorrido_hasta = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.CustomFormat = "dd-MM-yyyy h:m:s";
            this.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_inicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecha_inicio.Location = new System.Drawing.Point(126, 98);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(147, 20);
            this.fecha_inicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // fecha_fin
            // 
            this.fecha_fin.CustomFormat = "dd-MM-yyyy h:m:s";
            this.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_fin.Location = new System.Drawing.Point(126, 133);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(147, 20);
            this.fecha_fin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crucero";
            // 
            // combo_crucero
            // 
            this.combo_crucero.FormattingEnabled = true;
            this.combo_crucero.Location = new System.Drawing.Point(126, 26);
            this.combo_crucero.Name = "combo_crucero";
            this.combo_crucero.Size = new System.Drawing.Size(320, 21);
            this.combo_crucero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recorrido";
            // 
            // combo_recorrido_desde
            // 
            this.combo_recorrido_desde.FormattingEnabled = true;
            this.combo_recorrido_desde.Location = new System.Drawing.Point(126, 57);
            this.combo_recorrido_desde.Name = "combo_recorrido_desde";
            this.combo_recorrido_desde.Size = new System.Drawing.Size(147, 21);
            this.combo_recorrido_desde.TabIndex = 7;
            // 
            // combo_recorrido_hasta
            // 
            this.combo_recorrido_hasta.FormattingEnabled = true;
            this.combo_recorrido_hasta.Location = new System.Drawing.Point(300, 57);
            this.combo_recorrido_hasta.Name = "combo_recorrido_hasta";
            this.combo_recorrido_hasta.Size = new System.Drawing.Size(146, 21);
            this.combo_recorrido_hasta.TabIndex = 8;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(218, 206);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // AltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 262);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.combo_recorrido_hasta);
            this.Controls.Add(this.combo_recorrido_desde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_crucero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label1);
            this.Name = "AltaViaje";
            this.Text = "Agregar Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_crucero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_recorrido_desde;
        private System.Windows.Forms.ComboBox combo_recorrido_hasta;
        private System.Windows.Forms.Button btn_guardar;

    }
}