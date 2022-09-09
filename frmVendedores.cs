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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void ActualizarListBox()
        {
            lstVendedores.DataSource = null;
            lstVendedores.DataSource = clsListas.listaVendedores;
        }

        private void btnFacturacion_Click_1(object sender, EventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.Show();
            this.Hide();
        }

        private void btnAgregarVendedores_Click(object sender, EventArgs e)
        {

            if (txtVendedores.Text.Length > 0)
            {
                clsListas.listaVendedores.Add(txtVendedores.Text);
                clsListas.listaVendedores.Sort();

                ActualizarListBox();

                txtVendedores.Clear();
                txtVendedores.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un vendedor en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVendedores.Focus();
            }
        }

        private void btnEliminarVendedores_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro de eliminar el vendedor seleccionado?",
                               "ELIMINAR VENDEDOR",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                clsListas.listaVendedores.Remove(lstVendedores.SelectedValue.ToString());
            
                ActualizarListBox();
            }
        }

        private void txtVendedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregarVendedores.PerformClick();
            }
        }

        private void frmVendedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea finalizar la carga de Vendedores?",
                                           "FINAL DE CARGA",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Asterisk,
                                           MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre del formulario
            }
        }

        private void frmVendedores_Load(object sender, EventArgs e)
        {
            if (clsListas.listaVendedores.Count > 0)
            {
                ActualizarListBox();
            }
            txtVendedores.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
