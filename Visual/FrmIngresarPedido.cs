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
        static int i = 1;
        public FrmIngresarPedido()
        {
            InitializeComponent();
            ctrlPedido.LlenarCmbPedido(cmbPedido);
            ctrlPedido.LlenarCmbCliente(cmbCliente);
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
            string cliente = (string)cmbCliente.SelectedItem;

            string sCantItems = txtCantPedido.Text;
            string sTotalPed = txtTotPedido.Text;

            bool flag = ctrlPedido.IngresarPedido(sId, cliente, sCantItems, sTotalPed);
            
            
            
            
            FrmIngresarFactura frmIngresarFactura = new FrmIngresarFactura();

            if (flag)
            {
                i++;
                frmIngresarFactura.Show();

                txtCantPedido.Clear();
                txtTotPedido.Clear();
                dgvIngresoPedido.Rows.Clear();
                ctrlPedido.RestartPedido();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //string dataCliente = (string)cmbCliente.SelectedItem;
            //string []cliente = dataCliente.Split(',');
            //string cedula = cliente[1];
            //ctrlPedido.EliminarRegistroCliente(cedula);
            this.Close();
        }

        private void btnAggPedido_Click(object sender, EventArgs e)
        {
            string pedidoSleccionado = (string)cmbPedido.SelectedItem;
            string cantidadItem = txtCantItem.Text;
            Console.WriteLine(pedidoSleccionado);

            ctrlPedido.AgregarAlPedido(pedidoSleccionado, cantidadItem, dgvIngresoPedido, txtCantPedido, txtTotPedido);
        }
    }
}
