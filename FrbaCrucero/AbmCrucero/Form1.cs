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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_entrar_alta_crucero_Click(object sender, EventArgs e)
        {
            new AltaCrucero().Show();
        }

        private void button_entrar_baja_cruceros_Click(object sender, EventArgs e)
        {
            new BajaCrucero().Show();
        }
    }
}
