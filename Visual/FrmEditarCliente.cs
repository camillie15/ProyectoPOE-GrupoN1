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
    public partial class FrmEditarCliente : Form
    {
        private CtrlCliente ctrlCliente;
        private int idCliente;
        private FrmVisualizarCliente frm;
        public FrmEditarCliente(CtrlCliente ctrlCliente, int idCliente, string nombre, string apellido, string cedula, int edad, string email, string direccion, FrmVisualizarCliente frm)
        {
            InitializeComponent();
            this.ctrlCliente = ctrlCliente;
            this.idCliente = idCliente;
            this.frm = frm;

            txtEditNombre.Text = nombre;
            txtEditApellido.Text = apellido;
            txtEditCedula.Text = cedula;
            txtEditEmail.Text = email;
            txtEditEdad.Text = edad.ToString();
            txtEditDireccion.Text = direccion;
        }

        private void btnEditarConfirmacion_Click(object sender, EventArgs e)
        {
            ctrlCliente.EditarCliente(idCliente, txtEditNombre.Text, txtEditApellido.Text, txtEditCedula.Text, txtEditEdad.Text, txtEditDireccion.Text, txtEditEmail.Text);
            this.Close();
            frm.ActualizarDataGridView();
        }
    }
}
