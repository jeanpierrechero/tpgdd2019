using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class BajaRoles : Form
    {
        public BajaRoles()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BajaRoles_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BajaRoles_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaRolesActivos.listaRolesDisponibles' Puede moverla o quitarla según sea necesario.
            this.listaRolesDisponiblesTableAdapter1.Fill(this.listaRolesActivos.listaRolesDisponibles);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet1.listaRolesDisponibles' Puede moverla o quitarla según sea necesario.
            this.listaRolesDisponiblesTableAdapter.Fill(this.gD1C2019DataSet1.listaRolesDisponibles);

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
