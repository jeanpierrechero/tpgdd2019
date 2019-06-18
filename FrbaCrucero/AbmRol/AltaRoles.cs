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
    public partial class AltaRoles : Form
    {

        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
        int indice;
        int codigo_rol;
        public AltaRoles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaRoles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet12.listaFuncionalidades' Puede moverla o quitarla según sea necesario.
            this.listaFuncionalidadesTableAdapter.Fill(this.gD1C2019DataSet12.listaFuncionalidades);
            
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("dar_de_alta_role",c);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_rol",nombre_box.Text);
            codigo_rol = Convert.ToInt32(comando.Parameters["@rol_codigo"].Value);
            c.Close();
            c.Open();

            for (int i = 0; i < comboBoxSeleccionados.Items.Count;i++ )
            {
                c.Open();
                SqlCommand ingreso = new SqlCommand("asignar_funcionalidad_rol");
                ingreso.CommandType = CommandType.StoredProcedure;
                ingreso.Parameters.AddWithValue("@rol", codigo_rol);
                ingreso.Parameters.AddWithValue("@funcionalidad_nombre",comboBoxSeleccionados.Items[i].ToString());

            }

            
        }

        private void nombre_box_TextChanged(object sender, EventArgs e)
        {

        }

        public void comboBoxSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboBoxSeleccionados.SelectedIndex;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
          indice = comboBox_funcionalidades.SelectedIndex;
           
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
    }
}
