using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlCliente
    {

        private static List<Cliente> clientes = new List<Cliente>();
        CtrlConversiones conv = new CtrlConversiones();
        private DatosCliente dCliente = new DatosCliente();

        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public bool registrarCliente(string sNombre, string sApellido, string sCedula, string sEdad, string sEmail, string sDireccion)
        {
            bool flag = false;
            int edad = conv.toInt(sEdad);
            List<string> list = dCliente.ObtenerCedulas();
            Cliente cliente = null;
            int contador = 0;
            if (edad >= 0)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] != sCedula)
                    {
                        contador++;
                    }
                }

                if (contador == list.Count - 1)
                {
                    cliente = new Cliente(sNombre, sApellido, sCedula, edad, sEmail, true, 0, sDireccion);
                    string mensaje = dCliente.IngresarCliente(cliente);
                    MessageBox.Show($"{mensaje}", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = true;
                }
                else if (list.Count == 0)
                {
                    cliente = new Cliente(sNombre, sApellido, sCedula, edad, sEmail, true, 0, sDireccion);
                    string mensaje = dCliente.IngresarCliente(cliente);
                    MessageBox.Show($"{mensaje}");
                    flag = true;
                }
            }
            else
            {
                flag = false;
            }
            return flag;
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

        public void buscarCliente(DataGridView dvg, string nombre, string apellido, Button btn)
        {
            if (!(nombre.Trim() == string.Empty && apellido.Trim() == string.Empty))
            {
                clientes = dCliente.BuscarCliente(nombre, apellido);
                int filaIndex = 0;
                if (clientes.Count > 0)
                {
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (i < clientes.Count - 1)
                        {
                            dvg.Rows.Add();
                        }
                        dvg.Rows[filaIndex].Cells[0].Value = clientes[i].IdCliente;
                        dvg.Rows[filaIndex].Cells[1].Value = clientes[i].Nombre;
                        dvg.Rows[filaIndex].Cells[2].Value = clientes[i].Apellido;
                        dvg.Rows[filaIndex].Cells[3].Value = clientes[i].Cedula;
                        dvg.Rows[filaIndex].Cells[4].Value = clientes[i].Edad;
                        dvg.Rows[filaIndex].Cells[5].Value = clientes[i].Email;
                        dvg.Rows[filaIndex].Cells[6].Value = clientes[i].Direccion;
                        filaIndex++;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente con la informacion proporcionada", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese algun campo a buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn.Enabled = true;
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

        public void eliminarCliente(int posicion)
        {
            dCliente.EliminarCliente(posicion);
        }

        public void BuscarClienteFiltro(DataGridView dvg, int edad, string dominio)
        {
            List<Cliente> filtro = new List<Cliente>();


            if (!((edad.ToString().Trim() == string.Empty || edad == 0) && dominio.Trim() == string.Empty))
            {
                clientes = dCliente.BuscarClienteFiltro(edad, dominio);

                if (clientes.Count > 0)
                {
                    dvg.Rows.Clear();
                    int filaIndex = 0;
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (i < clientes.Count - 1)
                        {
                            dvg.Rows.Add();
                        }
                        dvg.Rows[filaIndex].Cells[0].Value = clientes[i].IdCliente;
                        dvg.Rows[filaIndex].Cells[1].Value = clientes[i].Nombre;
                        dvg.Rows[filaIndex].Cells[2].Value = clientes[i].Apellido;
                        dvg.Rows[filaIndex].Cells[3].Value = clientes[i].Cedula;
                        dvg.Rows[filaIndex].Cells[4].Value = clientes[i].Edad;
                        dvg.Rows[filaIndex].Cells[5].Value = clientes[i].Email;
                        dvg.Rows[filaIndex].Cells[6].Value = clientes[i].Direccion;
                        filaIndex++;
                    }
                }
                else
                {
                    dvg.Rows.Clear();
                    MessageBox.Show("No se encontro ningun cliente con la informacion proporcionada" , "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese algun campo a buscar");
            }
        }
    }
}
