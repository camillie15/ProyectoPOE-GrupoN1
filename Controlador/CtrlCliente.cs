using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Controlador
{

    public class CtrlCliente
    {

        private static List<Cliente> clientes = new List<Cliente>();
        CtrlConversiones conv = new CtrlConversiones();
        private Conexion cnBDD = new Conexion();
        private DatosCliente dCliente = new DatosCliente();

        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public bool registrarCliente(string sNombre, string sApellido, string sCedula, string sEdad, string sEmail, string sDireccion)
        {
            bool flag = false;
            int edad = conv.toInt(sEdad);
            int idCliente = clientes.Count + 1;
            Cliente cliente = null;
            if (edad >= 0)
            {
                cliente = new Cliente(sNombre, sApellido, sCedula, edad, sEmail, true, idCliente, sDireccion);
                string mensaje = dCliente.IngresarCliente(cliente);
                MessageBox.Show($"{mensaje}");
                //clientes.Add(cliente);
                //dCliente.IngresarCliente(cliente);
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        /*
        public void IngresarCliente(Cliente cliente)
        {
            string msg = string.Empty;
            string msjCnx = cnBDD.Conectar();
            if (msjCnx[0] == '1')
            {
                msg = dCliente.IngresarCliente(cliente, cnBDD.Cn);
                cnBDD.Desconectar();
            }
            else if (msjCnx[0] == '0')
            {
                MessageBox.Show("Ocurrio un error: " + msg);
            }
        }
        */
        public void ComprobarConexion()
        {
            string msg = string.Empty;
            string flag = cnBDD.Conectar();
            if (flag == "1")
            {
                msg = "Conexion exitosa";
            }
            else
            {
                msg = "No se pudo conectar: " + flag;
            }
            MessageBox.Show(msg);
        }

        public string idContador()
        {
            return Convert.ToString(dCliente.UltimoId() + 1);
        }

        public void PresentarClientes(DataGridView dvg)
        {
            clientes = dCliente.ObtenerClientes();
            for (int i = 0; i < clientes.Count; i++)
            {
                if (i < clientes.Count - 1)
                {
                    dvg.Rows.Add();
                }
                dvg.Rows[i].Cells[0].Value = clientes[i].IdCliente;
                dvg.Rows[i].Cells[1].Value = clientes[i].Nombre;
                dvg.Rows[i].Cells[2].Value = clientes[i].Apellido;
                dvg.Rows[i].Cells[3].Value = clientes[i].Cedula;
                dvg.Rows[i].Cells[4].Value = clientes[i].Edad;
                dvg.Rows[i].Cells[5].Value = clientes[i].Email;
                dvg.Rows[i].Cells[6].Value = clientes[i].Direccion;
            }

        }

        public void buscarCliente(DataGridView dvg, string flag, Button btn)
        {
            if (!(flag.Trim() == string.Empty))
            {
                var clt = clientes.Find(x => x.Cedula.Contains(flag));
                if (clt != null && clt.Cedula == flag.Trim())
                {
                    dvg.Rows[0].Cells[0].Value = clt.IdCliente;
                    dvg.Rows[0].Cells[1].Value = clt.Nombre;
                    dvg.Rows[0].Cells[2].Value = clt.Apellido;
                    dvg.Rows[0].Cells[3].Value = clt.Cedula;
                    dvg.Rows[0].Cells[4].Value = clt.Edad;
                    dvg.Rows[0].Cells[5].Value = clt.Email;
                    dvg.Rows[0].Cells[6].Value = clt.Direccion;
                }
                else
                {
                    MessageBox.Show("No se encontro el cliente");
                }
                btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese CI del cliente buscar");
            }

        }

        public void EditarCliente(int idCliente, string nombre, string apellido, string cedula, string sEdad, string direccion, string email)
        {
            Cliente cl = new Cliente(nombre, apellido, cedula, conv.toInt(sEdad), email, true, idCliente, direccion);
            dCliente.EditarCliente(cl);
            int posicion = Clientes.FindIndex(x => x.IdCliente == idCliente);
            if (posicion >= 0)
            {
                Clientes[posicion].Nombre = nombre;
                Clientes[posicion].Apellido = apellido;
                Clientes[posicion].Email = email;
                Clientes[posicion].Edad = conv.toInt(sEdad);
                Clientes[posicion].Cedula = cedula;
                Clientes[posicion].Direccion = direccion;
            }
        }

        public int buscarPosicion(string nombre, string apellido, string cedula, int edad, string email, bool estado, int id, string direccion)
        {
            int flag = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (id != clientes[i].IdCliente)
                {
                    continue;
                }
                else
                {
                    flag = i;
                    break;
                }
            }
            return flag;
        }

        public void eliminarCliente(int posicion)
        {
            dCliente.EliminarCliente(posicion);
            //clientes.RemoveAt(posicion);
        }

        /*
        public void RegistrarAutor(string text1, string text2, string text3, string text4)
        {
            dAutor.ingresarAutor(text1, text2, text3, text4);
        }
        */
    }
}
