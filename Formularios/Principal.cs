using Proyecto_Panaderia.Datos;
using Proyecto_Panaderia.Entidades;
using Proyecto_Panaderia.Formularios;
using Proyecto_Panaderia.Formularios.ActualizarProducto;
using Proyecto_Panaderia.Formularios.Ventas;
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
        DBHelper dbHelper;
        List<Productos> lProductos;

        public Principal()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
            lProductos = new List<Productos>();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaVenta venta = new NuevaVenta();
            venta.ShowDialog();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevo = new NuevoProducto();
            nuevo.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ListaProductos(); //Aca cuando lo abrimos ya nos carga la lista de precios
        }     
        
        private void actualizarListaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProductos(); //Aca para actualizar la lista de precios en el FRM principal
        }        

        private void ListaProductos()
        {
            lstProductos.Items.Clear();
            lProductos.Clear();

            DataTable tabla = dbHelper.Consultar("SP_CONSULTAR_PRODUCTOS");

            for (int i = 0; i < tabla.Rows.Count; i++) 
            {
                Productos p = new Productos();

                p.id = Convert.ToInt32(tabla.Rows[i][0]);
                p.nombre = tabla.Rows[i][3].ToString();
                p.precio = Convert.ToInt32(tabla.Rows[i][1]);
                p.description = tabla.Rows[i][2].ToString();

                lProductos.Add(p);
                lstProductos.Items.Add(p);
            }
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto act = new ActualizarProducto();
            act.Show();
        }
    }
}
