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

namespace Visual
{
    public partial class IngresarPedido : Form
    {
        CtrlPedido ctrlPedido = new CtrlPedido();
        CtrlCliente ctrlCliente = new CtrlCliente();
        static int i = 1;
        public IngresarPedido()
        {
            InitializeComponent();
            ctrlPedido.crearPlato();
            ctrlPedido.LlenarCmbPedido(cmbPedido);
            txtClientePed.Text = ctrlPedido.RetornarCICliente();
            txtIdPedido.Text = i.ToString();
            
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
            string cliente = txtClientePed.Text;
            string menu = CtrlPedido.PedidoR;
            string sCantItems = txtCantPedido.Text;
            string sTotalPed = txtTotPedido.Text;

            bool flag = ctrlPedido.IngresarPedido(sId, cliente, menu, sCantItems, sTotalPed);
            IngresarFactura ingresarFactura = new IngresarFactura();

            if (flag)
            {
                i++;
                ingresarFactura.Show();

                txtCantPedido.Clear();
                txtTotPedido.Clear();
                dgvIngresoPedido.Rows.Clear();
                ctrlPedido.RestartPedido();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string cedula = txtClientePed.Text;
            ctrlPedido.EliminarRegistroCliente(cedula);
            this.Close();
        }

        private void btnAggPedido_Click(object sender, EventArgs e)
        {
            string pedidoSleccionado = (string)cmbPedido.SelectedItem;
            string cantidadItem = txtCantItem.Text;

            ctrlPedido.AgregarAlPedido(pedidoSleccionado, cantidadItem, dgvIngresoPedido, txtCantPedido, txtTotPedido);

        }
    }
}
