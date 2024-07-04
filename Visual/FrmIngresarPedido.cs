using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visual
{
    public partial class FrmIngresarPedido : Form
    {
        CtrlPedido ctrlPedido = new CtrlPedido();
        CtrlCliente ctrlCliente = new CtrlCliente();
        public FrmIngresarPedido()
        {
            InitializeComponent();
            ctrlPedido.LlenarCmb(cmbPedido, "plato");
            ctrlPedido.LlenarCmb(cmbCliente, "cliente");
            txtIdPedido.Text = ctrlPedido.idPedido();
        }

        private void txtCantItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!char.IsDigit(caracter) && caracter != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void btnContinuarPedido_Click(object sender, EventArgs e)
        {
            string sId = txtIdPedido.Text;
            string cliente = (string)cmbCliente.SelectedItem;
            string sCantItems = txtCantPedido.Text;
            string sTotalPed = txtTotPedido.Text;

            bool flag = ctrlPedido.IngresarPedido(sId, cliente, sCantItems, sTotalPed);
            FrmIngresarFactura frmIngresarFactura = null;

            if (flag)
            {
                frmIngresarFactura = new FrmIngresarFactura();
                frmIngresarFactura.Show();

                txtCantPedido.Clear();
                txtTotPedido.Clear();
                dgvIngresoPedido.Rows.Clear();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggPedido_Click(object sender, EventArgs e)
        {
            string idPedido = txtIdPedido.Text;
            string pedidoSleccionado = (string)cmbPedido.SelectedItem;
            string cantidadItem = txtCantItem.Text;

            ctrlPedido.AgregarAlPedido(idPedido, pedidoSleccionado, cantidadItem, dgvIngresoPedido, txtCantPedido, txtTotPedido, "");
            txtCantItem.Clear();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            ctrlPedido.Conectar();
        }
    }
}
