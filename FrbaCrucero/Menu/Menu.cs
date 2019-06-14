using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Menu
{
    public partial class Menu : Form
    {
        private Usuario.Cliente login;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgregarRol(object sender, EventArgs e)
        {
            Hide();
            var altaRol = new AbmRol.AltaRoles();
            altaRol.Show();
        }

        private void listarRoles(object sender, EventArgs e)
        {
            Hide();
            var listRol = new AbmRol.ListarRoles();
            listRol.Show();
        }

    }
}
