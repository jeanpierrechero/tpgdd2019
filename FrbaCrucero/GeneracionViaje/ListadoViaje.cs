using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class ListadoViaje : Menu.Menu
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public ListadoViaje()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaCrucero.Properties.Settings.GD1C2019ConnectionString"].ConnectionString);

            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos() {
            cn.Open();
            cmd = new SqlCommand("select * from mavema_pie.listar_viajes_dos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);            
            da.Fill(dt);
            tabla_viaje.DataSource = dt;
            cn.Close();
            cargarFiltroPuertoOrigen();
            cargarFiltroPuertoDestino();
            
        }

        public void cargarFiltroPuertoOrigen()
        {
            cn.Open();
            cmd = new SqlCommand("select puer_codigo,puer_nombre from mavema_pie.listado_puertos_origen", cn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            /*DataTable dt2 = new DataTable();
            da.Fill(dt2);
            filtro_puerto_salida.DataSource = dt2;
            filtro_puerto_salida.ValueMember = "puer_codigo";
            filtro_puerto_salida.DisplayMember = "puer_nombre";*/



            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    filtro_puerto_salida.Items.Add(new { value = reader.GetString(1), text = reader.GetString(1) });
                    
                }
            }
            filtro_puerto_salida.DisplayMember = "text";
            filtro_puerto_salida.ValueMember = "Value";

            cn.Close();
        }

        public void cargarFiltroPuertoDestino()
        {
            cn.Open();
            cmd = new SqlCommand("select puer_codigo,puer_nombre from mavema_pie.listado_puertos_destino", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    filtro_puerto_llegada.Items.Add(new { value = reader.GetInt32(0).ToString(), text = reader.GetString(1) });

                }
            }
            filtro_puerto_llegada.DisplayMember = "text";
            filtro_puerto_llegada.ValueMember = "value";
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola" +filtro_puerto_salida.Text);
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "origen", filtro_puerto_salida.Text);
        }

        private void filtro_puerto_salida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*
            cn.Open();
            cmd = new SqlCommand("select puer_nombre from mavema_pie.listado_puertos_destino", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            filtro_puerto_llegada.DataSource = dt3;
            filtro_puerto_llegada.ValueMember = "puer_nombre";

            cn.Close();*/
        }

    }
}
