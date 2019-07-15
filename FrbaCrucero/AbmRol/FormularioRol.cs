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
        public FormularioRol(String codigo,String unNombre)
        {
            InitializeComponent();
            nombre_box.Text = unNombre;
            c.Open();
            SqlCommand comando = new SqlCommand("select f.func_nombre from mavema_pie.role r join mavema_pie.role_funcionalidad rf on r.role_codigo = rf.role_codigo join mavema_pie.funcionalidad f on f.func_codigo = rf.func_codigo where r.role_codigo ="+codigo_rol +"group by f.func_nombre  ", c);
            


            for (int i = 0; i < comando.Parameters.Count; i++)
            {
                comboBox_funcionalidades.Items[i] = comando.Parameters[i].Value.ToString();

            }
            c.Close();
        }

        public int indice;
        public String codigo_rol;
        
        
       
     
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
            SqlCommand comando = new SqlCommand("vaciarFuncionalidades", c);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@role", codigo_rol);
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
