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
    public partial class AltaRoles : Form
    {
        Rol unRol = new Rol();
        Funcionalidad funcionalidad = new Funcionalidad();
        Conexion c = new Conexion();
        public AltaRoles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaRoles_Load(object sender, EventArgs e)
        {
            c.llenar_combobox_funcionalidades(comboBox_funcionalidades);
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            unRol.set_nombre(nombre_box.Text);
            
        }

        private void nombre_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
