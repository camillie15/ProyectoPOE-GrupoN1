using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Controlador;

namespace Visual
{
    public partial class FrmIngresarCliente : Form
    {
        ControlEntradaTxt ctrllEntradaTxt = new ControlEntradaTxt();
        CtrlCliente ctrlCliente = new CtrlCliente();

        public FrmIngresarCliente()
        {
            InitializeComponent();
            this.txtIdCliente.Text = ctrlCliente.idContador();
        }

        private void btnContinuarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text.Trim();
            string apellido = txtApellidoCliente.Text.Trim();
            string cedula = txtCedulaCliente.Text.Trim();
            string edad = txtEdadCliente.Text.Trim();
            string email = txtEmailCliente.Text.Trim();
            string direccion = txtDireccionCliente.Text.Trim();
            if (nombre != "" && apellido != "" && cedula != "" && edad != "" && email != "" && direccion != "")
            {
                if (cedula.Length == 10)
                {
                    bool flag = ctrlCliente.registrarCliente(nombre, apellido, cedula, edad, email, direccion);
                    FrmIngresarPedido ingresarPedido = new FrmIngresarPedido();
                    if (flag)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con este numero de cedula", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar 10 digitos en CI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Control de tipo de caracteres aceptados, funcion ubicada en clase ControlEntradaTexto
        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrllEntradaTxt.ingresoSoloNumeros(sender, e);
        }

        // Control de limite de numeros que puede ingresar, funcion ubicada en clase ControlEntradaTexto
        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            ctrllEntradaTxt.maximoDigitosNumericos(sender, e, 10, txtCedulaCliente);
        }


        //Control de tipo de caracteres aceptados, funcion ubicada en clase ControlEntradaTexto
        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrllEntradaTxt.ingresoSoloLetras(sender, e);
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrllEntradaTxt.ingresoSoloLetras(sender, e);
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEdadCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrllEntradaTxt.ingresoSoloNumeros(sender, e);
        }
    }
}
