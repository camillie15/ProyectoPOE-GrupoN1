using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Visual
{
    public partial class FrmEditarPedido : Form
    {
        CtrlPedido ctrlPedido = new CtrlPedido();
        public FrmEditarPedido()
        {
            InitializeComponent();
            ctrlPedido.LlenarCmb(cmbPedido, "plato");
            ctrlPedido.LlenarCmb(cmbCliente, "cliente");
            ctrlPedido.LlenarFrmEditarPedido(txtIdPedido, dgvIngresoPedido, txtCantPedido, txtTotPedido, cmbCliente);
        }

        private void btnContinuarPedido_Click(object sender, EventArgs e)
        {
            string sId = txtIdPedido.Text;
            string cliente = (string)cmbCliente.SelectedItem;
            string sCantItems = txtCantPedido.Text;
            string sTotalPed = txtTotPedido.Text;

            bool flag = ctrlPedido.EditarPedido(sId, cliente, sCantItems, sTotalPed);

            FrmIngresarFactura frmIngresarFactura = new FrmIngresarFactura();

            if (flag)
            {
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
            FrmIngresarFactura frmIngresarFactura = new FrmIngresarFactura();
            frmIngresarFactura.Show();
        }

        private void btnAggPedido_Click(object sender, EventArgs e)
        {
            string idPedido = txtIdPedido.Text;
            string pedidoSeleccionado = (string)cmbPedido.SelectedItem;
            string cantidadItem = txtCantItem.Text;

            ctrlPedido.AgregarAlPedido(idPedido, pedidoSeleccionado, cantidadItem, dgvIngresoPedido, txtCantPedido, txtTotPedido, "editar");
            txtCantItem.Clear();
        }

        private void btnEliminarMenu_Click(object sender, EventArgs e)
        {
            if (dgvIngresoPedido.SelectedRows.Count > 0)
            {
                int rowIndex = dgvIngresoPedido.SelectedRows[0].Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar este plato de su pedido?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool flag = ctrlPedido.EliminarPlatoPedido(rowIndex, dgvIngresoPedido, txtCantPedido, txtTotPedido);
                    if (flag == true)
                    {
                        MessageBox.Show("Plato seleccionado eliminado del pedido");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }

        }
    }
}
