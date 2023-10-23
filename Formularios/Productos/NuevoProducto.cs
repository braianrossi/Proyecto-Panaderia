using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Panaderia.Datos;
using Proyecto_Panaderia.Entidades;

namespace Proyecto_Panaderia.Formularios
{
    public partial class NuevoProducto : Form
    {
        DBHelper gestor = null;
        List<Productos> lProductos;

        public NuevoProducto()
        {
            InitializeComponent();
            gestor = new DBHelper();
            lProductos = new List<Productos>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta cerrando la aplicacion.", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDescripcionProductoNuevo.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtDescripcionProductoNuevo.Text == string.Empty)
            {
                MessageBox.Show("Agregar una descripcion.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("Agregar un nuevo producto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Agregar un precio al producto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (int i = 0; i < lstProductosNuevaVenta.Items.Count; i++)
            {

                if (txtNombreProducto.Text == lProductos[i].nombre)
                {
                    MessageBox.Show("Este producto ya está existe.", "Control");
                    return;
                }
            }        

            GrabarProducto();

            Limpiar();
        }

        private void GrabarProducto()
        {
            Productos prod = new Productos();

            prod.precio = Convert.ToDouble(txtPrecio.Text);
            prod.nombre = txtNombreProducto.Text.ToString();
            prod.description = txtDescripcionProductoNuevo.Text.ToString();

            string consultaSQL = "insert into Productos values(@precio, @descripcion, @nombre_producto)";

            List<Parametros> lParametro = new List<Parametros>();
           
            lParametro.Add(new Parametros("@precio", prod.precio));
            lParametro.Add(new Parametros("@nombre_producto", prod.nombre));
            lParametro.Add(new Parametros("@descripcion", prod.description));

            if (gestor.actualizarBD(consultaSQL, lParametro) > 0)
            {
                MessageBox.Show("Se cargaron correctamente los datos.", "Control");
                ListaProductos();                
            }
            else
            {
                MessageBox.Show("No se cargaron correctamente los datos.", "Control");
            }
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            ListaProductos();
        }

        private void ListaProductos()
        {
            lstProductosNuevaVenta.Items.Clear();
            lProductos.Clear();

            DataTable tabla = gestor.Consultar("SP_CONSULTAR_PRODUCTOS");

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Productos p = new Productos();

                p.precio = Convert.ToInt32(tabla.Rows[i][1]);
                p.description = tabla.Rows[i][2].ToString();
                p.nombre = tabla.Rows[i][3].ToString();

                lProductos.Add(p);
                lstProductosNuevaVenta.Items.Add(p);
            }
        }
    }
}
