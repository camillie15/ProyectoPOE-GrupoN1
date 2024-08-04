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
    public partial class FrmEliminarPlato : Form
    {
        private CtrlPlato ctrlPlato;
        private CtrlPdfPlato ctrlPdfPlato;

        public FrmEliminarPlato(CtrlPlato ctrlPlato)
        {
            InitializeComponent();
            this.ctrlPlato = ctrlPlato;
            ctrlPdfPlato = new CtrlPdfPlato();
            ctrlPlato.LlenarPlatosEliminados(dgvEliminarPlato);
        }

        private void btnBuscarNunEli_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarNumEli.Text, out int idPlato))
            {
                CtrlPlato ctrlPlato = new CtrlPlato();
                ctrlPlato.LlenarEliminadosPorId(dgvEliminarPlato, idPlato);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void btnVolverPlato_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPrecio_Click(object sender, EventArgs e)
        {
            double precio = (double)nunPrecio.Value;
            CtrlPlato ctrlPlato = new CtrlPlato();
            ctrlPlato.LlenarEliminadosPorPrecio(dgvEliminarPlato, precio);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CtrlPlato ctrlPlato = new CtrlPlato();
            ctrlPlato.LlenarPlatosEliminados(dgvEliminarPlato);
        }

        private void btnGenerarPdfEli_Click(object sender, EventArgs e)
        {
            ctrlPdfPlato.GenerarPDF(dgvEliminarPlato);
            ctrlPdfPlato.AbrirPDF();
        }
    }
}
