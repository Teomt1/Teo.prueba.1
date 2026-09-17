using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Teo.prueba._1.PedidosMaterial
{
    public partial class SolicitudMaterialForm : Form
    {
        public SolicitudMaterialForm()
        {
            InitializeComponent();
        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
