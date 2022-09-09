using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sistemasDeVentas.clsListasVentasProductos;

namespace sistemasDeVentas
{
    public partial class frmProductos : Form
    {
       
        int ID;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if(txtProducto.Text.Length > 0 & txtPrecioProducto.Text.Length> 0)
            {
                clsListas.listaProductos.Add(txtProducto.Text);
                clsListas.listaProductos.Sort();

                clsListas.listaPrecio.Add(Convert.ToDouble(txtPrecioProducto.Text));
                clsListas.listaPrecio.Sort();

                clsProductosGlobal.Productos.Add(new clsProductos()
                {
                    Producto = txtProducto.Text,
                    Precio = Convert.ToDouble(txtPrecioProducto.Text)
                });

                ActualizarProductos();

                txtPrecioProducto.Clear();
                txtProducto.Clear();
                txtProducto.Focus();

            }
            else
            { 
                    MessageBox.Show("No se puede cargar un vendedor en blanco.",
                        "DATO INCORRECTO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtProducto.Focus();
                
            }

           
        }

        private void ActualizarProductos()
        {
            dtgProductos.DataSource = null;
            dtgProductos.DataSource = clsProductosGlobal.Productos;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dtgProductos.RowHeadersVisible = false;
           
            ActualizarProductos();
        }

        private void btnFacturacionMenu_Click(object sender, EventArgs e)
        {
            frmVendedores frm = new frmVendedores();
            frm.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsListas.listaPrecio.RemoveAt(ID);
            clsListas.listaProductos.RemoveAt(ID);
            clsProductosGlobal.Productos.RemoveAt(ID);
          
           ActualizarProductos();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dtgProductos.CurrentCell.RowIndex;
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPrecioProducto.Focus();
            }
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            if (e.KeyChar == 13)
            {
                btnGuardar.PerformClick();
            }
        }
        private KeyPressEventArgs SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) |
                char.ToString(e.KeyChar) == ".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e;
        }
    }
}
