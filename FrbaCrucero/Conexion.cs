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
using System.Configuration;


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
                    cn = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaCrucero.Properties.Settings.GD1C2019ConnectionString"].ConnectionString);
                }

                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
            

        }

       
      

         public string validateLogin(string username, string pass) {

             
             try
             {
                 cmd = new SqlCommand("select mavema_pie.func_login('" + username + "','" + pass + "')", cn);
                 var result =  cmd.ExecuteScalar().ToString();
                 return result;
                 
             }
             catch (Exception ex)
             {
                 throw ex;
             }

             
         }
    }
}
