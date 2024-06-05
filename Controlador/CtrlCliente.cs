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

        public void PresentarClientes(DataGridView dvg)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                dvg.Rows.Add();
                dvg.Rows[i].Cells[0].Value = clientes[i].IdCliente;
                dvg.Rows[i].Cells[1].Value = clientes[i].Nombre;
                dvg.Rows[i].Cells[2].Value = clientes[i].Apellido;
                dvg.Rows[i].Cells[3].Value = clientes[i].Cedula;
                dvg.Rows[i].Cells[4].Value = clientes[i].Email;
                dvg.Rows[i].Cells[5].Value = clientes[i].Direccion;
            }

        }

        public void buscarCliente (DataGridView dvg, string flag)
        {
            var clt = clientes.Find(x => x.Cedula.Contains(flag));
            dvg.Rows[0].Cells[0].Value = clt.IdCliente;
            dvg.Rows[0].Cells[1].Value = clt.Nombre;
            dvg.Rows[0].Cells[2].Value = clt.Apellido;
            dvg.Rows[0].Cells[3].Value = clt.Cedula;
            dvg.Rows[0].Cells[4].Value = clt.Email;
            dvg.Rows[0].Cells[5].Value = clt.Direccion;
        }

    }
}
