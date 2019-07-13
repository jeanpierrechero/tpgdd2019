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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_alta_rol_Click(object sender, EventArgs e)
        {
            new AltaRoles().Show();
        }

        private void boton_modif_rol_Click(object sender, EventArgs e)
        {
            new ModificacionRoles().Show();
        }

        private void boton_baja_rol_Click(object sender, EventArgs e)
        {
            new BajaRoles().Show();
        }

        private void boton_volver_roles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
