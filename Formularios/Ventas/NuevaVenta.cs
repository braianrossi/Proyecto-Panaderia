using Proyecto_Panaderia.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
            txtDescuento.Text = "0";
            txtSubTotal.Text = "0";
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

            foreach (DataGridViewRow Row in dgvGrilla.Rows)
            {
                if (Row.Cells["ColProducto"].Value.ToString() == cboProducto.Text)
                {
                    MessageBox.Show("Este producto ya esta elegido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }

            DataRowView item = (DataRowView)cboProducto.SelectedItem;

            int codigo = Convert.ToInt32(item.Row.ItemArray[0]);
            double precio = Convert.ToDouble(item.Row.ItemArray[1]);
            string producto = item.Row.ItemArray[2].ToString();
            int cantidad = Convert.ToInt32(txtCantidad.Text);


            dgvGrilla.Rows.Add(new object[] { codigo, producto, precio, cantidad });            

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.CurrentCell.ColumnIndex == 4)
            {
                dgvGrilla.Rows.RemoveAt(dgvGrilla.CurrentRow.Index);
            }            
        }

        private void btnCalcularTotal_Click_1(object sender, EventArgs e)
        {
            txtSubTotal.Text = string.Empty;

            if (txtDescuento.Text == " " || txtDescuento.Text == string.Empty)
            {
                MessageBox.Show("Ponga un descuento porfavor = 0!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvGrilla.Rows.Count < 1)
            {
                MessageBox.Show("Porfavor elija un producto para comprar!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double total = CalcularTotal();
            double descuento = total * (Convert.ToDouble(txtDescuento.Text) / 100);
            
            txtTotal.Text = total.ToString();

            if (txtDescuento.Text == "0")
            {
                txtDescuentoPP.Text = "0";
                txtSubTotal.Text = total.ToString();
            }
            else 
            {
                txtDescuentoPP.Text = descuento.ToString();
                txtSubTotal.Text = (total - descuento).ToString();
            }

            
        }

        private double CalcularTotal()
        {
            double total = 0;

            foreach (DataGridViewRow Row in dgvGrilla.Rows)
            {
                double precio = Convert.ToDouble(Row.Cells["ColPrecio"].Value);
                int cantidad = Convert.ToInt32(Row.Cells["ColCantidad"].Value);

                total += precio * cantidad;

            }

            return total;
        }
    }
}
