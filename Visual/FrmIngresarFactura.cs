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
    public partial class FrmIngresarFactura : Form
    {
        CtrlFactura ctrlFactura = new CtrlFactura();
        
        public FrmIngresarFactura()
        {
            InitializeComponent();
            this.txtCodfactura.Text = ctrlFactura.CrearId();
            //this.txtCliente.Text = ctrlFactura.RetornarClientePedido();
            ////string clienteInfo = ctrlFactura.RetornarClientePedido();
            ////this.txtCliente.Text = clienteInfo;
            ////this.txtSubtotal.Text = CtrlPedido.TotalPed.ToString();
            ////this.txtContenido.Text = CtrlPedido.PedidoR;
            ctrlFactura.llenarTxt(txtContenido, txtSubtotal, txtCliente);

        }


        private void btFinalizar_Click(object sender, EventArgs e)
        {
            
            string subtotal = txtSubtotal.Text;
            string iva = txtIva.Text;
            string total = txtTotal.Text;
            string idfactura = txtCodfactura.Text;

            ctrlFactura.IngresarFactura(iva, total, idfactura, subtotal);
            MessageBox.Show("Factura Generada");
            this.Close();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDevolucion.Text = (decimal.Parse(txtEfectivo.Text) - decimal.Parse(txtTotal.Text)).ToString();
            }
            catch { }

            if (txtEfectivo.Text == "")
            {
                txtDevolucion.Text = "";
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            string pSubtotal = txtSubtotal.Text;

            ctrlFactura.Calcular(pSubtotal, txtIva, txtTotal);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
