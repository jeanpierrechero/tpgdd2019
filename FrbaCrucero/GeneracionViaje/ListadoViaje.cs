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
            cn.Open();
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos() {
            
            cmd = new SqlCommand("select * from mavema_pie.listar_viajes_dos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);            
            da.Fill(dt);
            bs.DataSource = dt;
            tabla_viaje.DataSource = bs;


            filtro_fecha_salida.CustomFormat = " ";
            filtro_fecha_salida.Format = DateTimePickerFormat.Custom;

            filtro_fecha_llegada.CustomFormat = " ";
            filtro_fecha_llegada.Format = DateTimePickerFormat.Custom;
            
            cargarFiltroPuertoOrigen("null");
            cargarFiltroPuertoDestino("null");
            cargarFiltroCruceros();
            
        }

        public void cargarFiltroCruceros() {
            string query = "select cruc_codigo from mavema_pie.crucero";
            
            cmd = new SqlCommand(query, cn);

            SqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> test = new Dictionary<string, string>();

            if (reader.HasRows)
            {
                test.Add("0", "Todos");
                while (reader.Read())
                {
                    test.Add(reader.GetString(0), reader.GetString(0));
                }
            }
            filtro_crucero.DataSource = new BindingSource(test, null);
            filtro_crucero.DisplayMember = "Value";
            filtro_crucero.ValueMember = "Key";

            reader.Close();
        }

        public void cargarFiltroPuertoOrigen(string valor)
        {
            
            string query = "select puer_codigo,puer_nombre from mavema_pie.listado_puertos_origen";

            if (valor != "null" && valor != "0")
            {
                query = query + " where puer_nombre != " + "'" + valor + "'";
            }
            
            cmd = new SqlCommand(query, cn);

            SqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> test = new Dictionary<string, string>();

            if (reader.HasRows)
            {
                test.Add("0", "Todos");
                while (reader.Read())
                {
                    test.Add(reader.GetString(1), reader.GetString(1));
                }
            }
            filtro_puerto_salida.DataSource = new BindingSource(test, null);
            filtro_puerto_salida.DisplayMember = "Value";
            filtro_puerto_salida.ValueMember = "Key";

            reader.Close();
        }

        public void cargarFiltroPuertoDestino(string valor)
        {
            
            string query = "select puer_codigo,puer_nombre from mavema_pie.listado_puertos_destino";
            
            if (valor != "null" && valor != "0") {
                query = query + " where puer_nombre != " + "'"+valor+"'";
            }

            cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            Dictionary<string, string> test = new Dictionary<string, string>();

            if (reader.HasRows)
            {
                test.Add("0","Todos");
                while (reader.Read())
                {
                    test.Add(reader.GetString(1), reader.GetString(1));
                }
            }
            filtro_puerto_llegada.DataSource = new BindingSource(test, null);
            filtro_puerto_llegada.DisplayMember = "Value";
            filtro_puerto_llegada.ValueMember = "Key";
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var puerto_origen = ((KeyValuePair<string, string>)filtro_puerto_salida.SelectedItem).Key;
            var puerto_llegada = ((KeyValuePair<string, string>)filtro_puerto_llegada.SelectedItem).Key;
            var crucero = ((KeyValuePair<string, string>)filtro_crucero.SelectedItem).Key;
            string fecha_salida = filtro_fecha_salida.Text;
            string fecha_llegada = filtro_fecha_llegada.Text;
            
            if (puerto_origen == "0") {
                puerto_origen = "";
            }
            if (puerto_llegada == "0")
            {
                puerto_llegada = "";
            }
            if (crucero == "0")
            {
                crucero = "";
            }

            string condicion = "origen LIKE '%{0}%' and destino LIKE '%{1}%' and crucero LIKE '%{2}%'";

            if (!string.IsNullOrWhiteSpace(fecha_salida))
            {
                condicion = condicion + "and salida = '" + fecha_salida + "'";
            }

            if (!string.IsNullOrWhiteSpace(fecha_llegada))
            {
                condicion = condicion + "and llegada = '" + fecha_llegada + "'";
            }
            
            bs.Filter = string.Format(condicion, puerto_origen, puerto_llegada, crucero);
            
        }

        private void filtro_puerto_salida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value_puerto_origen = ((KeyValuePair<string, string>)filtro_puerto_salida.SelectedItem).Key;
            cargarFiltroPuertoDestino(value_puerto_origen);

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

<<<<<<< HEAD
        private void ListadoViaje_Load(object sender, EventArgs e)
        {
=======

        private void filtro_fecha_salida_ValueChanged(object sender, EventArgs e)
        {
            filtro_fecha_salida.CustomFormat = "yyyy-MM-dd h:m:s";
            filtro_fecha_salida.Format = DateTimePickerFormat.Custom;
        }

        private void filtro_fecha_llegada_ValueChanged(object sender, EventArgs e)
        {
            filtro_fecha_llegada.CustomFormat = "yyyy-MM-dd h:m:s";
            filtro_fecha_llegada.Format = DateTimePickerFormat.Custom;
>>>>>>> 60addb3bbf9a4e003ff4d8c70eb9cafe46309dc3

        }

    }
}
