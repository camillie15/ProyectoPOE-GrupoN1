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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuPedido_Click(object sender, EventArgs e)
        {
            IngresarCliente ingresarCliente = new IngresarCliente();
            ingresarCliente.Show();
        }

        private void btnOpcionesUsuario_Click(object sender, EventArgs e)
        {
            OpcionesAdministracion opcionesAdministraciones = new OpcionesAdministracion();
            opcionesAdministraciones.Show();
        }
    }
}
