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
        CtrlPedido ctrlPedido = new CtrlPedido();
        ControlEntradaTxt validacion = new ControlEntradaTxt();

        public FrmIngresarFactura()
        {
            InitializeComponent();
            this.txtCodfactura.Text = ctrlFactura.CrearId();
            ctrlFactura.llenarTxt(txtContenido, txtSubtotal, txtCliente);

            string ivaText, totalText;
            ctrlFactura.Calcular (txtSubtotal.Text, out ivaText, out totalText);
            txtIva.Text = ivaText;
            txtTotal.Text = totalText;
            this.txtSubtotal.TextChanged += new EventHandler(txtSubtotal_TextChanged);

        }
        private void btFinalizar_Click(object sender, EventArgs e)
        {

            string subtotal = txtSubtotal.Text;
            string iva = txtIva.Text;
            string total = txtTotal.Text;
            string idfactura = txtCodfactura.Text;
            string efectivo = txtEfectivo.Text;
            string pEstado = "Activo";
            string pFecha = dtpFecha.Text;
            string motivoA = "S/N";

            if (string.IsNullOrWhiteSpace(subtotal) ||
                string.IsNullOrWhiteSpace(iva) ||
                string.IsNullOrWhiteSpace(total) ||
                string.IsNullOrWhiteSpace(idfactura) ||
                string.IsNullOrWhiteSpace(efectivo))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ctrlFactura.IngresarFactura(iva, total, idfactura, subtotal, pEstado, motivoA, pFecha);
                MessageBox.Show("Factura Generada");
                ctrlPedido.RestartPedido();
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

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            validacion.ConvertirMayuscula(textBox);
        }

        private void btEditarPedido_Click(object sender, EventArgs e)
        {
            FrmEditarPedido frmEditarPedido = new FrmEditarPedido();
            frmEditarPedido.Show();
            this.Close();
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            ctrlPedido.EliminarRegistroPedido();
            ctrlPedido.RestartPedido();

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            string ivaText, totalText;
            ctrlFactura.Calcular(txtSubtotal.Text, out ivaText, out totalText);
            txtIva.Text = ivaText;
            txtTotal.Text = totalText;
        }

        private void FrmIngresarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
