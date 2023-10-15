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
            MessageBox.Show("Esta cerrando la aplicacion", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcionProductoNuevo.Text = string.Empty;
            txtProductoNuevo.Text = string.Empty;
            dgvGrilla.Rows.Clear();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtDescripcionProductoNuevo.Text == string.Empty)
            {
                MessageBox.Show("Agregar una descripcion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtProductoNuevo.Text == string.Empty)
            {
                MessageBox.Show("Agregar un nuevo producto!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Agregar un precio al producto!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (int i = 0; i < lstProductosNuevaVenta.Items.Count; i++)
            {

                if (txtProductoNuevo.Text == lProductos[i].description)
                {
                    MessageBox.Show("Este producto ya está existe...", "Control");
                    return;
                }
            }

            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                if (row.Cells["ColProducto"].Value.ToString() == txtProductoNuevo.Text)
                {
                    MessageBox.Show("Este producto ya está agregado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            int id = lstProductosNuevaVenta.Items.Count + dgvGrilla.Rows.Count + 1; ;
            string nom = txtProductoNuevo.Text;
            string desc = txtDescripcionProductoNuevo.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);

            dgvGrilla.Rows.Add(new object[] { id, nom, desc, precio });
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validamos que alla por lo menos un producto para agregar
            if (dgvGrilla.Rows.Count == 0)
            {
                MessageBox.Show("Debes cargar un producto nuevo minimo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrabarProducto();
        }

        private void GrabarProducto()
        {
            Productos prod = new Productos();
            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                prod.precio = Convert.ToDouble(row.Cells["ColPrecio"].Value);
                prod.description = row.Cells["ColDescripcion"].Value.ToString();

                string consultaSQL = "insert into Productos values(@precio, @descripcion)";

                List<Parametros> lParametro = new List<Parametros>();
                //lParametro.Add(new Parametros("id_producto", prod.id));
                lParametro.Add(new Parametros("@precio", prod.precio));
                lParametro.Add(new Parametros("@descripcion", prod.description));


                if (gestor.actualizarBD(consultaSQL, lParametro) > 0)
                {
                    MessageBox.Show("!!Se cargaron correctamente los datos");
                    ListaProductos();
                    dgvGrilla.Rows.Clear();
                }


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

                p.id = Convert.ToInt32(tabla.Rows[i][0]);
                p.precio = Convert.ToInt32(tabla.Rows[i][1]);
                p.description = tabla.Rows[i][2].ToString();


                lProductos.Add(p);
                lstProductosNuevaVenta.Items.Add(p);
            }
        }
    }
}
