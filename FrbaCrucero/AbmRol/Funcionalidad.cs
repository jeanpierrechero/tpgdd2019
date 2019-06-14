using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmRol
{
    public class Funcionalidad
    {
        private int id_funcionalidad;
        private String descripcion_funcionalidad;

        public void set_id(int unId)
        {
            this.id_funcionalidad = unId;
        }

        public void set_descripcion(String unaDescripcion)
        {
            this.descripcion_funcionalidad = unaDescripcion;
        }
        public int get_id()
        {
            return this.id_funcionalidad;
        }
        public String get_descripcion_funcionalidad()
        {
            return this.descripcion_funcionalidad;
        }


    }

}
