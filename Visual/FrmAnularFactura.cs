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
    public partial class FrmAnularFactura : Form
    {
        CtrlFactura ctrlFactura = new CtrlFactura();
        ControlEntradaTxt validacion = new ControlEntradaTxt();
        private FrmVisualizarFactura visualizarFactura;

        public FrmAnularFactura(CtrlFactura ctrlFactura, int idFactura, double iva, double total, double subtotal, bool estado, DateTime fecha, FrmVisualizarFactura visualizarFactura)
        {
            InitializeComponent();
            this.visualizarFactura = visualizarFactura;
            ctrlFactura.llenarTxt(txtAnularContenido, txtAnularSubtotal, txtAnularCliente);

            this.txtAnularCodfactura.Text = idFactura.ToString();
            txtAnularIva.Text = iva.ToString();
            txtAnularTotal.Text = total.ToString();
            txtAnularSubtotal.Text = subtotal.ToString();
            cmbAnularEstado.SelectedItem = estado ? "Activo" : "Inactivo";
            dtpFechaA.Value = fecha;
        }


        private void txtMotivoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetter(letra) && letra != ' ' && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

        }

        private void btRegistroAnulacion_Click(object sender, EventArgs e)
        {
            try
            {
                int idFactura = Convert.ToInt32(txtAnularCodfactura.Text);
                bool nuevoEstado = cmbAnularEstado.SelectedItem.ToString() == "Activo";
                string nuevoMotivo = txtMotivoA.Text;
                ctrlFactura.EditarFactura(idFactura, nuevoEstado, nuevoMotivo);
                MessageBox.Show("Factura editada correctamente.");
                visualizarFactura.ActualizarData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtMotivoA_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            validacion.ConvertirMayuscula(textBox);
        }

    }
}
