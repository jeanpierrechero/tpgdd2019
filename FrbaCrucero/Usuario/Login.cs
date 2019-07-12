using FrbaCrucero.Exceptions;
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
        Conexion con;
        public Login()
        {
            con = new Conexion();
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string username = txt_usuario.Text;
            string pass = txt_password.Text;

            string result = con.validateLogin(txt_usuario.Text, txt_password.Text);
            
            if (result == "0")
            {
                MessageBox.Show("Usuario o Password incorrecto.");
            }
            else {
                Hide();
                var menu = new Menu.Menu();
                menu.Show();
            }
        }
    }
}
