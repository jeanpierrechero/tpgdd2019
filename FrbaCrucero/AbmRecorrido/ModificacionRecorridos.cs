using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificacionRecorridos : Form
    {
        public ModificacionRecorridos()
        {
            InitializeComponent();
        }

        private void ModificacionRecorridos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet4.lista_recorridos' Puede moverla o quitarla según sea necesario.
            this.lista_recorridosTableAdapter.Fill(this.gD1C2019DataSet4.lista_recorridos);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
