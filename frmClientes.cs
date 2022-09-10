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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void ActualizarListBox()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = clsListas.listaClientes;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtClientes.Text.Length > 0)
            {
                clsListas.listaClientes.Add(txtClientes.Text);
                clsListas.listaClientes.Sort();

                ActualizarListBox();

                txtClientes.Clear();
                txtClientes.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un vendedor en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtClientes.Focus();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro de eliminar el vendedor seleccionado?",
                   "ELIMINAR VENDEDOR",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                clsListas.listaClientes.Remove(lstClientes.SelectedValue.ToString());

                ActualizarListBox();
            }
        }

        private void txtClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregarCliente.PerformClick();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            if (clsListas.listaClientes.Count > 0)
            {
                ActualizarListBox();
            }
            txtClientes.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
