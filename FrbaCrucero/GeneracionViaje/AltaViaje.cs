﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class AltaViaje : Menu.Menu
    {
        public AltaViaje()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*codigo*/

            Hide();
            var listado = new GeneracionViaje.ListadoViaje();
            listado.Show();
        }

        private void AltaViaje_Load(object sender, EventArgs e)
        {

        }

    }
}
