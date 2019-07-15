namespace FrbaCrucero.AbmCrucero
{
    partial class FormularioCrucero
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
            this.button_guardar = new System.Windows.Forms.Button();
            this.comboBox_fabricante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.listaFabricantesParaCombobox = new FrbaCrucero.listaFabricantesParaCombobox();
            this.listaFabricantesParaComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFabricanteTableAdapter = new FrbaCrucero.listaFabricantesParaComboboxTableAdapters.listaFabricanteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_modelo);
            this.groupBox1.Controls.Add(this.button_guardar);
            this.groupBox1.Controls.Add(this.comboBox_fabricante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crucero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(6, 174);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 5;
            this.button_guardar.Text = "Aceptar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // comboBox_fabricante
            // 
            this.comboBox_fabricante.DataSource = this.listaFabricanteBindingSource;
            this.comboBox_fabricante.FormattingEnabled = true;
            this.comboBox_fabricante.Location = new System.Drawing.Point(117, 24);
            this.comboBox_fabricante.Name = "comboBox_fabricante";
            this.comboBox_fabricante.Size = new System.Drawing.Size(186, 21);
            this.comboBox_fabricante.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo";
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Location = new System.Drawing.Point(117, 64);
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(186, 20);
            this.textBox_modelo.TabIndex = 8;
            this.textBox_modelo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(12, 273);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 9;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            // 
            // listaFabricantesParaCombobox
            // 
            this.listaFabricantesParaCombobox.DataSetName = "listaFabricantesParaCombobox";
            this.listaFabricantesParaCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaFabricantesParaComboboxBindingSource
            // 
            this.listaFabricantesParaComboboxBindingSource.DataSource = this.listaFabricantesParaCombobox;
            this.listaFabricantesParaComboboxBindingSource.Position = 0;
            // 
            // listaFabricanteBindingSource
            // 
            this.listaFabricanteBindingSource.DataMember = "listaFabricante";
            this.listaFabricanteBindingSource.DataSource = this.listaFabricantesParaComboboxBindingSource;
            // 
            // listaFabricanteTableAdapter
            // 
            this.listaFabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 308);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioCrucero";
            this.Text = "FormularioCrucero";
            this.Load += new System.EventHandler(this.FormularioCrucero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.ComboBox comboBox_fabricante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.BindingSource listaFabricantesParaComboboxBindingSource;
        private listaFabricantesParaCombobox listaFabricantesParaCombobox;
        private System.Windows.Forms.BindingSource listaFabricanteBindingSource;
        private listaFabricantesParaComboboxTableAdapters.listaFabricanteTableAdapter listaFabricanteTableAdapter;
    }
}