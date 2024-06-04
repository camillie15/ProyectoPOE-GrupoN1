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
    public partial class IngresarCliente : Form
    {
        ControlEntradaTxt ctrllEntradaTxt = new ControlEntradaTxt();
        CtrlCliente ctrlCliente = new CtrlCliente();    

        public IngresarCliente()
        {
            InitializeComponent();
            this.txtIdCliente.Text = ctrlCliente.idContador();
        }

        private void btnContinuarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text;
            string apellido = txtApellidoCliente.Text;
            string cedula = txtCedulaCliente.Text;
            string edad = txtEdadCliente.Text;
            string email = txtEmailCliente.Text;
            string direccion = txtDireccionCliente.Text;
            bool flag = ctrlCliente.registrarCliente(nombre, apellido, cedula, edad, email, direccion);
            IngresarPedido ingresarPedido = new IngresarPedido();
            if (flag)
            {
                ingresarPedido.Show();
                this.Close();
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
            ctrllEntradaTxt.maximoDigitosNumericos(sender, e , 10 , txtCedulaCliente);
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
