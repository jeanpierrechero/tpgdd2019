using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void usuario_cliente(object sender, EventArgs e)
        {
            Hide();
            var login = new Usuario.Cliente();
            login.Show();
        }

        private void usuario_login(object sender, EventArgs e)
        {
            Hide();
            var login = new Usuario.Login();
            login.Show();
        }
    }
}
