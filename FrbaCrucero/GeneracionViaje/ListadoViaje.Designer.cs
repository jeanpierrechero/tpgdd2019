namespace FrbaCrucero.GeneracionViaje
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
            this.tabla_viaje = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro_crucero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filtro_puerto_salida = new System.Windows.Forms.ComboBox();
            this.filtro_puerto_llegada = new System.Windows.Forms.ComboBox();
            this.filtro_fecha_salida = new System.Windows.Forms.DateTimePicker();
            this.filtro_fecha_llegada = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_viaje)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_viaje
            // 
            this.tabla_viaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_viaje.Location = new System.Drawing.Point(20, 172);
            this.tabla_viaje.Name = "tabla_viaje";
            this.tabla_viaje.Size = new System.Drawing.Size(704, 142);
            this.tabla_viaje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crucero";
            // 
            // filtro_crucero
            // 
            this.filtro_crucero.FormattingEnabled = true;
            this.filtro_crucero.Location = new System.Drawing.Point(129, 39);
            this.filtro_crucero.Name = "filtro_crucero";
            this.filtro_crucero.Size = new System.Drawing.Size(177, 21);
            this.filtro_crucero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puerto Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puerto Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Llegada";
            // 
            // filtro_puerto_salida
            // 
            this.filtro_puerto_salida.FormattingEnabled = true;
            this.filtro_puerto_salida.Location = new System.Drawing.Point(129, 67);
            this.filtro_puerto_salida.Name = "filtro_puerto_salida";
            this.filtro_puerto_salida.Size = new System.Drawing.Size(177, 21);
            this.filtro_puerto_salida.TabIndex = 7;
            this.filtro_puerto_salida.SelectedIndexChanged += new System.EventHandler(this.filtro_puerto_salida_SelectedIndexChanged);
            // 
            // filtro_puerto_llegada
            // 
            this.filtro_puerto_llegada.FormattingEnabled = true;
            this.filtro_puerto_llegada.Location = new System.Drawing.Point(129, 97);
            this.filtro_puerto_llegada.Name = "filtro_puerto_llegada";
            this.filtro_puerto_llegada.Size = new System.Drawing.Size(177, 21);
            this.filtro_puerto_llegada.TabIndex = 8;
            // 
            // filtro_fecha_salida
            // 
            this.filtro_fecha_salida.CustomFormat = "yyyy-MM-dd h:m:s";
            this.filtro_fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filtro_fecha_salida.Location = new System.Drawing.Point(524, 35);
            this.filtro_fecha_salida.Name = "filtro_fecha_salida";
            this.filtro_fecha_salida.Size = new System.Drawing.Size(200, 20);
            this.filtro_fecha_salida.TabIndex = 9;
            this.filtro_fecha_salida.Value = new System.DateTime(2019, 7, 14, 16, 40, 34, 0);
            this.filtro_fecha_salida.ValueChanged += new System.EventHandler(this.filtro_fecha_salida_ValueChanged);
            // 
            // filtro_fecha_llegada
            // 
            this.filtro_fecha_llegada.CustomFormat = "yyyy-MM-dd h:m:s";
            this.filtro_fecha_llegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filtro_fecha_llegada.Location = new System.Drawing.Point(524, 63);
            this.filtro_fecha_llegada.Name = "filtro_fecha_llegada";
            this.filtro_fecha_llegada.Size = new System.Drawing.Size(200, 20);
            this.filtro_fecha_llegada.TabIndex = 10;
            this.filtro_fecha_llegada.Value = new System.DateTime(2019, 7, 14, 4, 40, 34, 0);
            this.filtro_fecha_llegada.ValueChanged += new System.EventHandler(this.filtro_fecha_llegada_ValueChanged);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(20, 139);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListadoViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 347);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.filtro_fecha_llegada);
            this.Controls.Add(this.filtro_fecha_salida);
            this.Controls.Add(this.filtro_puerto_llegada);
            this.Controls.Add(this.filtro_puerto_salida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filtro_crucero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla_viaje);
            this.Name = "ListadoViaje";
            this.Text = "Listado de Viajes";
            this.Load += new System.EventHandler(this.ListadoViaje_Load);
            this.Controls.SetChildIndex(this.tabla_viaje, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.filtro_crucero, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.filtro_puerto_salida, 0);
            this.Controls.SetChildIndex(this.filtro_puerto_llegada, 0);
            this.Controls.SetChildIndex(this.filtro_fecha_salida, 0);
            this.Controls.SetChildIndex(this.filtro_fecha_llegada, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_viaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_viaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filtro_crucero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox filtro_puerto_salida;
        private System.Windows.Forms.ComboBox filtro_puerto_llegada;
        private System.Windows.Forms.DateTimePicker filtro_fecha_salida;
        private System.Windows.Forms.DateTimePicker filtro_fecha_llegada;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button button2;
    }
}