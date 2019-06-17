using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaCrucero.Exceptions;


namespace FrbaCrucero
{
     public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Conexion()
        {
            try
            {
                if (cn == null)
                {
                    cn = new SqlConnection("Data Source=localhost;Initial Catalog=GD1C2019;User ID=sa;Password=1234");
                }

                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
            

        }

       
      

         public string validateLogin(string username, string pass) {

             var result = "0";
             try
             {
                 cmd = new SqlCommand("select mavema_pie.func_login('" + username + "','" + pass + "')", cn);
                 result =  cmd.ExecuteScalar().ToString();
                 
             }
             catch (Exception ex)
             {
                 throw ex;
             }

             return result;
         }
    }
}
