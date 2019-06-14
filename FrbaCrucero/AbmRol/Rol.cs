using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmRol
{
    public class Rol
    {
        private String nombre;
        private List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public void set_nombre(String unNombre)
        {
            this.nombre = unNombre;
        }

        public void set_funcionalidad(Funcionalidad unaF)
        {
            this.funcionalidades.Add(unaF);
        }

        public String get_nombre()
        {
            return this.nombre;
        }

        public List<Funcionalidad> get_funcionalidades()
        {
            return this.funcionalidades;
        }


    }
}
