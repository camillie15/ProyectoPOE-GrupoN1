using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Controlador
{

    public class CtrlCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        CtrlConversiones conv = new CtrlConversiones();

        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public bool registrarCliente (string sNombre, string sApellido, string sCedula, string sEdad, string sEmail, string sDireccion)
        {
            bool flag = false;
            int edad = conv.toInt (sEdad);
            int idCliente = clientes.Count +1;
            if (edad >= 0 ) {
                Cliente cliente = new Cliente(sNombre, sApellido, sCedula, edad, sEmail, true, idCliente, sDireccion);
                //MessageBox.Show($"Registrado con exito");
                clientes.Add(cliente);
                flag = true;
            }
            else
            {
                MessageBox.Show($"Ingrese una edad Valida");
                flag = false;
            }
            return flag;
        }

        public string idContador()
        {
            return Convert.ToString(clientes.Count + 1);
        }
    }
}
