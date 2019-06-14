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
    public partial class BajaCrucero : Form
    {
        public BajaCrucero()
        {
            InitializeComponent();
        }

        private void BajaCrucero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet9.listaCrucerosDisponibles' Puede moverla o quitarla según sea necesario.
            this.listaCrucerosDisponiblesTableAdapter1.Fill(this.gD1C2019DataSet9.listaCrucerosDisponibles);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet8.listaCrucerosDisponibles' Puede moverla o quitarla según sea necesario.
            this.listaCrucerosDisponiblesTableAdapter.Fill(this.gD1C2019DataSet8.listaCrucerosDisponibles);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet7.listaCruceros' Puede moverla o quitarla según sea necesario.
            this.listaCrucerosTableAdapter.Fill(this.gD1C2019DataSet7.listaCruceros);

        }
    }
}
