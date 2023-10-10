using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Panaderia.Datos;


namespace Proyecto_Panaderia.Formularios
{
    public partial class NuevoProducto : Form
    {
        DBHelper gestor = null;

        public NuevoProducto()
        {
            InitializeComponent();
            gestor = new DBHelper();           
        }

        private void CargarProductos()
        {
            DataTable tabla = gestor.Consultar("SP_CONSULTAR_PRODUCTOS");
            cboProductos.DataSource = tabla;
            cboProductos.DisplayMember = "descripcion";
            cboProductos.ValueMember = "id_producto";
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
            for (int i = 0; i < cboProductos.SelectionLength; i++)
            {
                string s = txtProductoNuevo.Text;

                MessageBox.Show(s);

                if (txtProductoNuevo.Text == (cboProductos.Text[i]).ToString())
                {
                    MessageBox.Show("Este producto ya está existe...", "Control");
                    return;
                }
            }
            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                if (row.Cells["Producto"].Value.ToString() == txtProductoNuevo.Text)
                {
                    MessageBox.Show("Este producto ya está agregado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }



            string nom = txtProductoNuevo.Text;
            string desc = txtDescripcionProductoNuevo.Text;

            dgvGrilla.Rows.Add(new object[] { nom, desc });

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
