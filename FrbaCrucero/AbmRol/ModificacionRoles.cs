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
    public partial class ModificacionRoles : Form
    {
        SqlConnection c = new SqlConnection(FrbaCrucero.Properties.Settings.Default.GD1C2019ConnectionString);
        public ModificacionRoles()
        {
            InitializeComponent();
        }

        private void ModificacionRoles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaRolesTotal.listaRoles' Puede moverla o quitarla según sea necesario.
            this.listaRolesTableAdapter1.Fill(this.listaRolesTotal.listaRoles);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet3.listaRoles' Puede moverla o quitarla según sea necesario.
            this.listaRolesTableAdapter.Fill(this.gD1C2019DataSet3.listaRoles);

        }
        public String codigo;
        public String nombre;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Seleccion")
            {
               codigo= dataGridView1.SelectedCells[0].Value.ToString();
               nombre = dataGridView1.SelectedCells[1].Value.ToString();
               new FormularioRol(codigo, nombre).Show();
            }
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE LIKE '{0}%'", textBox_nombre.Text);
        }

        private void checkBox_solo_activos_CheckedChanged(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("select r.role_nombre NOMBRE,f.func_nombre FUNCIONALIDAD,r.role_activo ESTADO from mavema_pie.role r join mavema_pie.role_funcionalidad  r_f on r.role_codigo = r_f.role_codigo join mavema_pie.funcionalidad f on r_f.func_codigo = f.func_codigo where r.role_activo = 1  group by r.role_nombre,f.func_nombre,r.role_activo", c);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();

        }

        private void checkBox_solo_no_activos_CheckedChanged(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand comando = new SqlCommand("select r.role_nombre NOMBRE,f.func_nombre FUNCIONALIDAD,r.role_activo ESTADO from mavema_pie.role r join mavema_pie.role_funcionalidad  r_f on r.role_codigo = r_f.role_codigo join mavema_pie.funcionalidad f on r_f.func_codigo = f.func_codigo where r.role_activo = 0  group by r.role_nombre,f.func_nombre,r.role_activo", c); 
           comando.ExecuteNonQuery();
     
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            c.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
