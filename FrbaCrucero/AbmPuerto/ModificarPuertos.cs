using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    public partial class ModificarPuertos : Form
    {
        public ModificarPuertos()
        {
            InitializeComponent();
        }

        private void ModificarPuertos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet6.puerto' Puede moverla o quitarla según sea necesario.
            this.puertoTableAdapter.Fill(this.gD1C2019DataSet6.puerto);

        }
    }
}
