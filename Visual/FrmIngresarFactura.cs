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
            this.txtCliente.Text = ctrlFactura.obternercliente();
            txtSubtotal.Text = CtrlPedido.TotalPed.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodfactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
           string cliente = txtCliente.Text;
           string subtotal = txtSubtotal.Text;
           string iva = txtIva.Text;
           string total= txtTotal.Text;
           string idfactura = txtCodfactura.Text;

            ctrlFactura.IngresarFactura(cliente,subtotal,iva,total,idfactura);
            MessageBox.Show(" Factura Generada ");
            this.Close();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(txtTotal.Text)).ToString();
            }
            catch { }

            if (txtEfectivo.Text == "")
            {
                lblDevolucion.Text = "";
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" En Mantemiento ");
        }
    }
}
