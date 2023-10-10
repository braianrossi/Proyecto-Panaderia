using Proyecto_Panaderia.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panaderia
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevo = new NuevoProducto();
            nuevo.ShowDialog();
        }
    }
}
