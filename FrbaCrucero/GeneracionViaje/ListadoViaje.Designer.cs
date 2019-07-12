﻿namespace FrbaCrucero.GeneracionViaje
{
    partial class ListadoViaje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro_crucero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filtro_puerto_salida = new System.Windows.Forms.ComboBox();
            this.filtro_puerto_llegada = new System.Windows.Forms.ComboBox();
            this.filtro_fecha_salida = new System.Windows.Forms.DateTimePicker();
            this.filtro_fecha_llegada = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salida,
            this.Destino,
            this.Crucero,
            this.fecha_salida,
            this.fecha_llegada,
            this.fecha_estimada});
            this.dataGridView1.Location = new System.Drawing.Point(13, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // Salida
            // 
            this.Salida.DataPropertyName = "(none)";
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Crucero
            // 
            this.Crucero.HeaderText = "Crucero";
            this.Crucero.Name = "Crucero";
            // 
            // fecha_salida
            // 
            this.fecha_salida.HeaderText = "Fecha Salida";
            this.fecha_salida.Name = "fecha_salida";
            // 
            // fecha_llegada
            // 
            this.fecha_llegada.HeaderText = "Fecha Llegada";
            this.fecha_llegada.Name = "fecha_llegada";
            // 
            // fecha_estimada
            // 
            this.fecha_estimada.HeaderText = "Fecha estimada de llegada";
            this.fecha_estimada.Name = "fecha_estimada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crucero";
            // 
            // filtro_crucero
            // 
            this.filtro_crucero.FormattingEnabled = true;
            this.filtro_crucero.Location = new System.Drawing.Point(122, 23);
            this.filtro_crucero.Name = "filtro_crucero";
            this.filtro_crucero.Size = new System.Drawing.Size(154, 21);
            this.filtro_crucero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puerto Salida";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puerto Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Llegada";
            // 
            // filtro_puerto_salida
            // 
            this.filtro_puerto_salida.FormattingEnabled = true;
            this.filtro_puerto_salida.Location = new System.Drawing.Point(122, 48);
            this.filtro_puerto_salida.Name = "filtro_puerto_salida";
            this.filtro_puerto_salida.Size = new System.Drawing.Size(154, 21);
            this.filtro_puerto_salida.TabIndex = 7;
            // 
            // filtro_puerto_llegada
            // 
            this.filtro_puerto_llegada.FormattingEnabled = true;
            this.filtro_puerto_llegada.Location = new System.Drawing.Point(122, 76);
            this.filtro_puerto_llegada.Name = "filtro_puerto_llegada";
            this.filtro_puerto_llegada.Size = new System.Drawing.Size(154, 21);
            this.filtro_puerto_llegada.TabIndex = 8;
            // 
            // filtro_fecha_salida
            // 
            this.filtro_fecha_salida.CustomFormat = "dd-MM-yyyy h:m:s";
            this.filtro_fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filtro_fecha_salida.Location = new System.Drawing.Point(439, 23);
            this.filtro_fecha_salida.Name = "filtro_fecha_salida";
            this.filtro_fecha_salida.Size = new System.Drawing.Size(200, 20);
            this.filtro_fecha_salida.TabIndex = 9;
            // 
            // filtro_fecha_llegada
            // 
            this.filtro_fecha_llegada.CustomFormat = "dd-MM-yyyy h:m:s";
            this.filtro_fecha_llegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filtro_fecha_llegada.Location = new System.Drawing.Point(439, 51);
            this.filtro_fecha_llegada.Name = "filtro_fecha_llegada";
            this.filtro_fecha_llegada.Size = new System.Drawing.Size(200, 20);
            this.filtro_fecha_llegada.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListadoViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtro_fecha_llegada);
            this.Controls.Add(this.filtro_fecha_salida);
            this.Controls.Add(this.filtro_puerto_llegada);
            this.Controls.Add(this.filtro_puerto_salida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filtro_crucero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoViaje";
            this.Text = "Listado de Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_estimada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filtro_crucero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox filtro_puerto_salida;
        private System.Windows.Forms.ComboBox filtro_puerto_llegada;
        private System.Windows.Forms.DateTimePicker filtro_fecha_salida;
        private System.Windows.Forms.DateTimePicker filtro_fecha_llegada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}