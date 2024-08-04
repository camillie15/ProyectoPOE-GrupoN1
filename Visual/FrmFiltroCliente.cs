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
    public partial class FrmFiltroCliente : Form
    {
        CtrlCliente ctrlCliente;
        public FrmFiltroCliente()
        {
            InitializeComponent();
            dgvCliente.Rows.Clear();
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            ctrlCliente = new CtrlCliente();
            if (cbConfirmacion.Checked)
            {
                ctrlCliente.BuscarClienteFiltro(dgvCliente, (int)nudEdad.Value, txtGmail.Text);
            }
            else
            {
                ctrlCliente.BuscarClienteFiltro(dgvCliente, 0, txtGmail.Text);
            }

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            string namePdf = "Filtro Espacial clientes.pdf";
            if (dgvCliente.Rows.Count != 0 && dgvCliente.Rows[0].Cells[0].Value != null)
            {
                CtrlPdfCliente ctrlPdfCliente = new CtrlPdfCliente();
                ctrlPdfCliente.GenerarPdf(dgvCliente, namePdf);
                ctrlPdfCliente.AbrirPdf(namePdf);
            }
            else
            {
                MessageBox.Show("No hay niguna fila para generar PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
