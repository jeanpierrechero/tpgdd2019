using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Usuario
{
    public partial class Login : Form
    {
        private Inicio inicio;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            /*
             realizar la validación
             */
            Hide();
            var menu = new Menu.Menu();
            menu.Show();
        }
    }
}
