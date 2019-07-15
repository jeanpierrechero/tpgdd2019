using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.DAO
{
    class Viaje
    {
        private String origen { get; set; }
        private String destino { get; set; }
        private String cruceroDenominacion { get; set; }
        private DateTime fecha_salida { get; set; }
        private DateTime fecha_llegada { get; set; }
        private DateTime fecha_estimada { get; set; }

        public Viaje(String orig, String des, String cruDeno, DateTime fs, DateTime fe) {
            origen = orig;
            destino = des;
            cruceroDenominacion = cruDeno;
            fecha_salida = fs;
            fecha_estimada = fe;
        }
    }
}
