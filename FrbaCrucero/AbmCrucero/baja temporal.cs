using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCrucero.AbmCrucero
{
    public partial class baja_temporal : Form
    {
        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
        public String codigo;
        public baja_temporal(String cod)
        {
            InitializeComponent();
            codigo = cod;
        }

        private void baja_temporal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            new ConfirmacionCancelacionPasajes(codigo,fecha_box.Text,Comentario_box.Text).Show();
            
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
