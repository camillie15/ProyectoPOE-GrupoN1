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
        ControlEntradaTxt validacion = new ControlEntradaTxt();

        public FrmIngresarFactura()
        {
            InitializeComponent();
            this.txtCodfactura.Text = ctrlFactura.CrearId();
            ctrlFactura.llenarTxt(txtContenido, txtSubtotal, txtCliente);

        }
        private void btFinalizar_Click(object sender, EventArgs e)
        {

            string subtotal = txtSubtotal.Text;
            string iva = txtIva.Text;
            string total = txtTotal.Text;
            string idfactura = txtCodfactura.Text;
            string efectivo = txtEfectivo.Text;
            string pEstado = cmbEstado.SelectedItem?.ToString();
            string pFecha = dtpFecha.Text;
            string motivoA = txtMotivo.Text;

            if (string.IsNullOrWhiteSpace(subtotal) ||
                string.IsNullOrWhiteSpace(iva) ||
                string.IsNullOrWhiteSpace(total) ||
                string.IsNullOrWhiteSpace(idfactura) ||
                string.IsNullOrWhiteSpace(efectivo) ||
                string.IsNullOrWhiteSpace(motivoA))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ctrlFactura.IngresarFactura(iva, total, idfactura, subtotal, pEstado, motivoA, pFecha);
                MessageBox.Show("Factura Generada");
                this.Close();
            }
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

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            validacion.ConvertirMayuscula(textBox);
        }
    }
}
