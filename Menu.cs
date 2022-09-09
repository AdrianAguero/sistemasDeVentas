using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasDeVentas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAltaVendedoresMenu_Click(object sender, EventArgs e)
        {
            frmVendedores frm = new frmVendedores();
            frm.Show();
           // this.Hide();
        }

        private void btnAltaProductosMenu_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.Show();
         //   this.Hide();
        }

        private void btnAltaClientesMenu_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
          //  this.Hide();
        }

        private void btnFacturacionMenu_Click(object sender, EventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.Show();
           // this.Hide();
        }

        private void btnInformesMenu_Click(object sender, EventArgs e)
        {
            frmInformes frm = new frmInformes();
            frm.Show();
           // this.Hide();
        }
    }
}
