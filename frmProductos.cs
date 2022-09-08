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

                clsListaProducos.Productos.Add(new clsProductos()
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
            dtgProductos.DataSource = clsListaProducos.Productos;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dtgProductos.RowHeadersVisible = false;
            //Enlazo el DataGridView a una lista, de esta manera se veran reflejados los cambios en la lista
            //en el DataGredView
            dtgProductos.DataSource = clsListaProducos.Productos;
        }

        private void btnFacturacionMenu_Click(object sender, EventArgs e)
        {
            frmVendedores frm = new frmVendedores();
            frm.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsListaProducos.Productos.RemoveAt(dtgProductos.Rows.Count-1);
            ActualizarProductos();
        }
    }
}
