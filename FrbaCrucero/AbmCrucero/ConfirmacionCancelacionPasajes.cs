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
    public partial class ConfirmacionCancelacionPasajes : Form
    {
        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
         
        public String codigo;
        public String fecha;
        public String comentario;
        public ConfirmacionCancelacionPasajes(String cod,String f,String c)
        {
            InitializeComponent();
            codigo = cod;
            comentario = c;
            fecha = f;
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmacionCancelacionPasajes_Load(object sender, EventArgs e)
        {

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("baja_temporal_crucero", c);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_crucero", codigo);
            comando.Parameters.AddWithValue("@fecha_estimada_fin", fecha);
            comando.Parameters.AddWithValue("@comentario", comentario);
            c.Close();
            this.Close();
        }

        private void button_rechazar_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("baja_temporal_crucero", c);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_crucero", codigo);
            comando.Parameters.AddWithValue("@fecha_estimada_fin", fecha);
            comando.Parameters.AddWithValue("@comentario", comentario);
            c.Close();
            this.Close();

        }
    }
}
