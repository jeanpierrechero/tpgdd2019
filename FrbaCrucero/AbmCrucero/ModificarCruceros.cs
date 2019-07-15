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
    public partial class ModificarCruceros : Form
    {
        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
        
        public ModificarCruceros()
        {
            InitializeComponent();
        }

        private void ModificarCruceros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaModelosComboBox.listaModelo' Puede moverla o quitarla según sea necesario.
            this.listaModeloTableAdapter.Fill(this.listaModelosComboBox.listaModelo);
            // TODO: esta línea de código carga datos en la tabla 'listaFabricantesParaCombobox.listaFabricante' Puede moverla o quitarla según sea necesario.
            this.listaFabricanteTableAdapter.Fill(this.listaFabricantesParaCombobox.listaFabricante);
            // TODO: esta línea de código carga datos en la tabla 'listaCrucerosDisponibles._listaCrucerosDisponibles' Puede moverla o quitarla según sea necesario.
            this.listaCrucerosDisponiblesTableAdapter.Fill(this.listaCrucerosDisponibles._listaCrucerosDisponibles);

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_codigo.Clear();
           
        }

        private void textBox_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_buscar_con_parametros_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE LIKE '{0}%'", textBox_codigo.Text);
        }

        private void comboBox_fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("select cruc_codigo CODIGO,cruc_modelo MODELO,(select fabr_nombre from mavema_pie.fabricante where fabr_codigo = cruc_fabricante) FABRICANTE,(select esta_descripcion_corta from mavema_pie.estado e where cruc_codigo = e.esta_codigo ) ESTADO,cruc_fecha_alta FECHA_ALTA,cruc_baja FECHA_BAJA_TEMPORAL from mavema_pie.crucero where cruc_baja_DEFINITIVA is null and fabr_nombre = " + comboBox_fabricante.SelectedText + "  group by cruc_codigo,cruc_modelo,cruc_fabricante,cruc_fecha_alta,cruc_baja", c);
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void comboBox_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("select cruc_codigo CODIGO,cruc_modelo MODELO,(select fabr_nombre from mavema_pie.fabricante where fabr_codigo = cruc_fabricante) FABRICANTE,(select esta_descripcion_corta from mavema_pie.estado e where cruc_codigo = e.esta_codigo ) ESTADO,cruc_fecha_alta FECHA_ALTA,cruc_baja FECHA_BAJA_TEMPORAL from mavema_pie.crucero where cruc_baja_DEFINITIVA is null and fabr_nombre = " + comboBox_modelo.SelectedText + "  group by cruc_codigo,cruc_modelo,cruc_fabricante,cruc_fecha_alta,cruc_baja", c);
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }
    }
}
