﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class FormularioCrucero : Form
    {
        private String codigo;
        public FormularioCrucero(String cod)
        {
            InitializeComponent();
            codigo = cod;
        }


        private void FormularioCrucero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaFabricantesParaCombobox.listaFabricante' Puede moverla o quitarla según sea necesario.
            this.listaFabricanteTableAdapter.Fill(this.listaFabricantesParaCombobox.listaFabricante);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
