using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class VistaListado : Menu.Menu
    {
        private Seleccion vistaAnterior;
        public VistaListado(Seleccion form)
        {
            vistaAnterior = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            vistaAnterior.Show();
        }
    }
}
