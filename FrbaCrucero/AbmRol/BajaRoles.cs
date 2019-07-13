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

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE LIKE '{0}%'", textBox_nombre.Text);
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
