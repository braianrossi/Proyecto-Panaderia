using Proyecto_Panaderia.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panaderia.Formularios.Ventas
{
    public partial class NuevaVenta : Form
    {
        DBHelper dbHelper;
        public NuevaVenta()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            CargarProductos();
            txtCliente.Text = "CONSUMIDOR FINAL";
            txtCantidad.Text = "1";
            cboProducto.SelectedIndex = 0;
            txtTotal.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta cerrando la aplicacion", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void CargarProductos()
        {
            DataTable tabla = dbHelper.Consultar("SP_CONSULTAR_PRODUCTOS");
            cboProducto.DataSource = tabla;
            cboProducto.DisplayMember = "descripcion";
            cboProducto.ValueMember = "id_producto";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Agregar una cantidad!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCliente.Text == string.Empty)
            {
                MessageBox.Show("Agregar un nombre del cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Agregar un producto!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataRowView item = (DataRowView)cboProducto.SelectedItem;

            int codigo = Convert.ToInt32(item.Row.ItemArray[0]);
            double precio = Convert.ToDouble(item.Row.ItemArray[1]);
            string producto = item.Row.ItemArray[2].ToString();
            int cantidad = Convert.ToInt32(txtCantidad.Text);


            dgvGrilla.Rows.Add(new object[] { codigo, producto, precio, cantidad });

            ActualizarPrecio();

        }

        private void ActualizarPrecio()
        {
            Double TotalAnterior = Convert.ToDouble(txtTotal.Text); 

            DataRowView item = (DataRowView)cboProducto.SelectedItem;

            double precio = Convert.ToDouble(item.Row.ItemArray[1]);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            double Total = precio * cantidad;

            TotalAnterior = Total + TotalAnterior;

            txtTotal.Text = TotalAnterior.ToString() ;
            //Solucionar esto con un for o forech para que de vuelta dentro de la grilla y asi me actualice el precio al eliminar algun producto

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.CurrentCell.ColumnIndex == 4)
            {
                dgvGrilla.Rows.RemoveAt(dgvGrilla.CurrentRow.Index);
            }
            RestarPrecio();
        }

        private void RestarPrecio()
        {
            Double TotalAnterior = Convert.ToDouble(txtTotal.Text);

            DataRowView item = (DataRowView)cboProducto.SelectedItem;

            double precio = Convert.ToDouble(item.Row.ItemArray[1]);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            double Total = precio * cantidad;

            TotalAnterior = TotalAnterior - Total;

            txtTotal.Text = TotalAnterior.ToString();
        }
    }
}
