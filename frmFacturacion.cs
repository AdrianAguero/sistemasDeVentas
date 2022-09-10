using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sistemasDeVentas.clsListasVentasProductos;

namespace sistemasDeVentas
{
    public partial class frmFacturacion : Form
    {
       
        double varPrecio;
        double precioAcumulado;
        public frmFacturacion()
        {
            InitializeComponent();
        }



        private void LimpiarControles()
        {
            numericUpDown1.Value = 0;
        }




        private void ActualizarVendedores()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            //frmVendedores frm = new frmVendedores();//instancio el formulario
           // frm.ShowDialog();   //abro el formulario 
            cmbVendedores.Items.Clear(); //vacío el ComboBox
            cmbVendedores.Items.AddRange(clsListas.listaVendedores.ToArray()); //cargo el ComboBox a partir de una lista
            cmbVendedores.SelectedIndex = 0; // selecciono el primer elemento del ComboBox


            cmbProducto.Items.Clear();
            cmbProducto.Items.AddRange(clsListas.listaProductos.ToArray());
            cmbProducto.SelectedIndex = 0;

            cmbCliente.Items.Clear();
            cmbCliente.Items.AddRange(clsListas.listaClientes.ToArray());
            cmbCliente.SelectedIndex = 0;

        }

        private void btnAgregarOtroVendedor_Click(object sender, EventArgs e)
        {
            frmVendedores frm = new frmVendedores();//instancio el formulario
            frm.Show();
            this.Hide();
            ActualizarVendedores();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            // para que no se pueda escribir en el combobox
            cmbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            //llamo al metodo que actualiza el combo de vendedores
            ActualizarVendedores();
            //la siguiente linea oculta la cabecera de fila de un DataGridView
            dtgVentas.RowHeadersVisible = false;
            //Enlazo el DataGridView a una lista, de esta manera se veran reflejados los cambios en la lista
            //en el DataGredView
            dtgVentas.DataSource = clsListaVentas.ventas;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {

            ObtenerPrecioProducto();
           
           
           
            clsListaVentas.ventas.Add(new clsVentas()
            {
                Vendedor = cmbVendedores.Text,    //agrego vendedor
                Cliente= cmbCliente.Text,
                Producto = cmbProducto.Text,
                Precio = varPrecio,
                Cantidad = Convert.ToInt32(numericUpDown1.Text),
                Total = Convert.ToInt32(numericUpDown1.Text) * varPrecio
            }) ;
            precioAcumulado += (Convert.ToDouble(numericUpDown1.Text) * varPrecio);
            txtSubTotal.Text = Convert.ToString(precioAcumulado);
            txtGanancias.Text = Convert.ToString(precioAcumulado * 0.30);
            txtTotal.Text = Convert.ToString(precioAcumulado * 1.30);

            //llamo al metodo que actualiza el DataGridView de ventas
            //a partir de la lista anterior
            ActualizarVentas();
            //Llamo al metodo que limpia los controles
            LimpiarControles();
        }


        private void ActualizarVentas()
        {
            //Método que actualiza el DataGridView a partir de la lista de ventas
            dtgVentas.DataSource = null; //Limpio el DataGredView
            dtgVentas.DataSource = clsListaVentas.ventas; //Enlado el DataGridView a la lista
        }

      

        private void ObtenerPrecioProducto()
        {
            //string varProducto;
            //string varPrecio;
            foreach (var a in clsProductosGlobal.Productos)
            {
                if (a.Producto == cmbProducto.Text)
                {
                    varPrecio = a.Precio;
                }
            }
        }
    }
}
