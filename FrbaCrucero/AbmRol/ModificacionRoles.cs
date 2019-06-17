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
    public partial class ModificacionRoles : Form
    {
        public ModificacionRoles()
        {
            InitializeComponent();
        }

        private void ModificacionRoles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaRolesTotal.listaRoles' Puede moverla o quitarla según sea necesario.
            this.listaRolesTableAdapter1.Fill(this.listaRolesTotal.listaRoles);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet3.listaRoles' Puede moverla o quitarla según sea necesario.
            this.listaRolesTableAdapter.Fill(this.gD1C2019DataSet3.listaRoles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
