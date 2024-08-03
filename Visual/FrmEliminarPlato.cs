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

        public FrmEliminarPlato(CtrlPlato ctrlPlato)
        {
            InitializeComponent();
            this.ctrlPlato = ctrlPlato;
            ctrlPlato.LlenarPlatosEliminados(dgvEliminarPlato);
        }

        private void FrmEliminarPlato_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverPlato_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}