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

    public partial class AltaCrucero : Form
    {
        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
        public String fabricante;
        public AltaCrucero()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void AltaCrucero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaModelosComboBox.listaModelo' Puede moverla o quitarla según sea necesario.
            this.listaModeloTableAdapter.Fill(this.listaModelosComboBox.listaModelo);
            // TODO: esta línea de código carga datos en la tabla 'listaFabricantesParaCombobox.listaFabricante' Puede moverla o quitarla según sea necesario.
            this.listaFabricanteTableAdapter.Fill(this.listaFabricantesParaCombobox.listaFabricante);

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fabricante = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //modelo = comboBox2.SelectedItem.ToString();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_aceptar_alta_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand ingreso = new SqlCommand("alta_crucero");
            ingreso.CommandType = CommandType.StoredProcedure;
            ingreso.Parameters.AddWithValue("@modelo", textBox_modelo.Text);
            ingreso.Parameters.AddWithValue("@fabricante_nombre", fabricante);
            c.Close();
        }

        private void textBox_modelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tipoServicio_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 60addb3bbf9a4e003ff4d8c70eb9cafe46309dc3
    }
}
