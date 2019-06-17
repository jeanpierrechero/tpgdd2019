using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class ListarRoles : Menu.Menu
    {
        public ListarRoles()
        {
            InitializeComponent();
            llenarListadoRoles();
        }

        public void llenarListadoRoles()
        {
            try
            {
                
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("Nombree"));
                table.Columns.Add(new DataColumn("Seleccionar"));
                
                DataRow row = table.NewRow();
                row[0] = "Nombre de rol";
                row[1] = "botones de acciones";
                table.Rows.Add(row);

                tabla_roles.DataSource = table;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox " + ex.ToString());
            }

        }

        private void ListarRoles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet12.listaFuncionalidades' Puede moverla o quitarla según sea necesario.
            this.listaFuncionalidadesTableAdapter.Fill(this.gD1C2019DataSet12.listaFuncionalidades);
            // TODO: esta línea de código carga datos en la tabla 'listaRolesActivos.listaRolesDisponibles' Puede moverla o quitarla según sea necesario.
            this.listaRolesDisponiblesTableAdapter.Fill(this.listaRolesActivos.listaRolesDisponibles);
            // TODO: esta línea de código carga datos en la tabla 'listaRolesTotal.listaRoles' Puede moverla o quitarla según sea necesario.
            this.listaRolesTableAdapter.Fill(this.listaRolesTotal.listaRoles);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2019DataSet11.listaRoles' Puede moverla o quitarla según sea necesario.
            this.listaRolesTableAdapter1.Fill(this.gD1C2019DataSet11.listaRoles);
            

        }

        private void comboBox_busqueda_funcionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
