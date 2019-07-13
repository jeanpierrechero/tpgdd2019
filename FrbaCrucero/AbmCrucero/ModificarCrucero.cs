using System;
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
    public partial class ModificarCrucero : Form
    {
        public ModificarCrucero()
        {
            InitializeComponent();
        }

        private void ModificarCrucero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaFabricante._listaFabricante' Puede moverla o quitarla según sea necesario.
            this.listaFabricanteTableAdapter.Fill(this.listaFabricante._listaFabricante);
            // TODO: esta línea de código carga datos en la tabla 'listaModelos.listaModelo' Puede moverla o quitarla según sea necesario.
            this.listaModeloTableAdapter.Fill(this.listaModelos.listaModelo);
            // TODO: esta línea de código carga datos en la tabla 'listaCruceros._listaCruceros' Puede moverla o quitarla según sea necesario.
            this.listaCrucerosTableAdapter.Fill(this.listaCruceros._listaCruceros);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
