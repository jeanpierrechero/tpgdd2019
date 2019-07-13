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

namespace FrbaCrucero.AbmRol
{
    public partial class FormularioRol : Form
    {
        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
        public FormularioRol(int codigo,String unNombre,List<String> funcionalidades)
        {
            InitializeComponent();
            nombre_box.Text = unNombre;
            for (int i = 0; i < funcionalidades.Count(); i++)
            {
                comboBox_funcionalidades.Items[0] = funcionalidades[0];

            }
        }

        public int indice;
        public int codigo_rol;
        
       
     
        private void nombre_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            indice = comboBox_funcionalidades.SelectedIndex;
        }

        private void comboBox_funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_agregar_funcionalidad_Click(object sender, EventArgs e)
        {
            comboBoxSeleccionados.Items.Add(comboBox_funcionalidades.Items[indice]);
        }

        private void button_borrar_funcionalidad_Click(object sender, EventArgs e)
        {
            comboBoxSeleccionados.Items.Remove(comboBoxSeleccionados.Items[indice]);
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            comboBoxSeleccionados.Items.Clear();
            nombre_box.Clear();
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("dar_de_alta_role", c);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_rol", nombre_box.Text);
            codigo_rol = Convert.ToInt32(comando.Parameters["@rol_codigo"].Value);
            c.Close();
            c.Open();

            for (int i = 0; i < comboBoxSeleccionados.Items.Count; i++)
            {
                c.Open();
                SqlCommand ingreso = new SqlCommand("asignar_funcionalidad_rol");
                ingreso.CommandType = CommandType.StoredProcedure;
                ingreso.Parameters.AddWithValue("@rol", codigo_rol);
                ingreso.Parameters.AddWithValue("@funcionalidad_nombre", comboBoxSeleccionados.Items[i].ToString());

            }
        }

        private void comboBoxSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboBox_funcionalidades.SelectedIndex;
        }
    }
}
