namespace FrbaCrucero.AbmCrucero
{
    partial class AltaCrucero
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
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.button_aceptar_alta = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaFabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFabricantesParaCombobox = new FrbaCrucero.listaFabricantesParaCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaModelosComboBox = new FrbaCrucero.listaModelosComboBox();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.listaFabricanteTableAdapter = new FrbaCrucero.listaFabricantesParaComboboxTableAdapters.listaFabricanteTableAdapter();
            this.listaModeloTableAdapter = new FrbaCrucero.listaModelosComboBoxTableAdapters.listaModeloTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_modelo);
            this.groupBox1.Controls.Add(this.button_aceptar_alta);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Crucero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Location = new System.Drawing.Point(107, 72);
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(121, 20);
            this.textBox_modelo.TabIndex = 3;
            this.textBox_modelo.TextChanged += new System.EventHandler(this.textBox_modelo_TextChanged);
            // 
            // button_aceptar_alta
            // 
            this.button_aceptar_alta.Location = new System.Drawing.Point(218, 195);
            this.button_aceptar_alta.Name = "button_aceptar_alta";
            this.button_aceptar_alta.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar_alta.TabIndex = 1;
            this.button_aceptar_alta.Text = "Aceptar";
            this.button_aceptar_alta.UseVisualStyleBackColor = true;
            this.button_aceptar_alta.Click += new System.EventHandler(this.button_aceptar_alta_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.listaFabricanteBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listaFabricanteBindingSource
            // 
            this.listaFabricanteBindingSource.DataMember = "listaFabricante";
            this.listaFabricanteBindingSource.DataSource = this.listaFabricantesParaCombobox;
            // 
            // listaFabricantesParaCombobox
            // 
            this.listaFabricantesParaCombobox.DataSetName = "listaFabricantesParaCombobox";
            this.listaFabricantesParaCombobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // listaModeloBindingSource
            // 
            this.listaModeloBindingSource.DataMember = "listaModelo";
            this.listaModeloBindingSource.DataSource = this.listaModelosComboBox;
            // 
            // listaModelosComboBox
            // 
            this.listaModelosComboBox.DataSetName = "listaModelosComboBox";
            this.listaModelosComboBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(12, 270);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 1;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(231, 270);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // listaFabricanteTableAdapter
            // 
            this.listaFabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // listaModeloTableAdapter
            // 
            this.listaModeloTableAdapter.ClearBeforeFill = true;
            // 
            // AltaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 305);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaCrucero";
            this.Text = "AltaCrucero";
            this.Load += new System.EventHandler(this.AltaCrucero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFabricantesParaCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_aceptar_alta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_salir;
        private listaFabricantesParaCombobox listaFabricantesParaCombobox;
        private System.Windows.Forms.BindingSource listaFabricanteBindingSource;
        private listaFabricantesParaComboboxTableAdapters.listaFabricanteTableAdapter listaFabricanteTableAdapter;
        private listaModelosComboBox listaModelosComboBox;
        private System.Windows.Forms.BindingSource listaModeloBindingSource;
        private listaModelosComboBoxTableAdapters.listaModeloTableAdapter listaModeloTableAdapter;
        private System.Windows.Forms.TextBox textBox_modelo;
    }
}