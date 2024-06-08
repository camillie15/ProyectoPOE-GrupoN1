using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlPedido
    {
        private int cantidades = 0;
        private double totalPed = 0;
        static List<Pedido> listaPedidos = new List<Pedido>();

        List<Plato> listaPlatos = new List<Plato>();
        static List<Plato> menuPedido = new List<Plato>();
        List<Cliente> listaClientes = new List<Cliente>();


        CtrlConversiones ctrlConversiones = new CtrlConversiones();
        public CtrlPedido()
        {
            CrearClientes();
            CrearPlato();
            RestartPedido();
        }

        public static List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public int Cantidades { get => cantidades; set => cantidades = value; }
        public double TotalPed { get => totalPed; set => totalPed = value; }

        public void AgregarAlPedido(string pedidoSleccionado, string cantidadItem, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido)
        {
            int cantItemAgregado = ctrlConversiones.toInt(cantidadItem);

            if (pedidoSleccionado != null && cantItemAgregado > 0)
            {
                Plato platoAgg = listaPlatos.Find(delBuscar => delBuscar.IdPlato == TratarPlato(pedidoSleccionado).IdPlato);
                menuPedido.Add(platoAgg);

                string descripcionPed = platoAgg.Descripcion;
                double precioItem = platoAgg.Precio;
                int cantidadItemPed = ctrlConversiones.toInt(cantidadItem);

                double totalPedidoItem = precioItem * cantidadItemPed;

                int i = dgvIngresoPedido.Rows.Add();

                dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = descripcionPed;
                dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = $"$ {precioItem}";
                dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = cantidadItemPed;
                dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = $"$ {totalPedidoItem}";

                Cantidades += cantidadItemPed;
                TotalPed += (precioItem * cantidadItemPed);
                txtCantPedido.Text = Cantidades.ToString();
                txtTotPedido.Text = $"$ {TotalPed.ToString()}";

            }
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
            }
        }

        public void CrearPlato()
        {
            listaPlatos.Add(new Plato(1, "Combo1", "Hamburguesa + papas", 3.5, true));
            listaPlatos.Add(new Plato(2, "Combo2", "Nuggets + papas", 2.7, true));
            listaPlatos.Add(new Plato(3, "Combo3", "Hamburguesa + bebida", 4.8, true));
            listaPlatos.Add(new Plato(4, "Combo4", "Papas Bacon", 2.5, true));
            listaPlatos.Add(new Plato(5, "Combo5", "Pack 2 Hamburguesas", 5.5, true));
        }

        public void CrearClientes()
        {
            listaClientes.Add(new Cliente("Cami", "Ayovi", "0987656789", 21, "camillie.com", true, 1, "Norte"));
            listaClientes.Add(new Cliente("Erick", "Cordova", "0986756789", 22, "erick.com", true, 2, "Norte"));
            listaClientes.Add(new Cliente("Juliet", "Ortuno", "0984444789", 23, "juliet.com", true, 3, "Norte"));
            listaClientes.Add(new Cliente("Daniel", "Aguilar", "0934566789", 24, "daniel.com", true, 4, "Norte"));

        }

        public void LlenarCmb(ComboBox cmbData, string tipo)
        {
            if (tipo.ToLower().Equals("cliente"))
            {
                foreach (Cliente cliente in listaClientes)
                {
                    cmbData.Items.Add($"{cliente.Nombre}, {cliente.Apellido}, {cliente.Cedula}");
                }
            }
            else if (tipo.ToLower().Equals("plato"))
            {

                foreach (Plato plato in listaPlatos)
                {
                    if (plato.Estado == true)
                    {
                        cmbData.Items.Add($"{plato.IdPlato}, {plato.Descripcion}, - ${plato.Precio}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data en ComboBox no inicializada");
            }
        }

        public bool IngresarPedido(string sId, string cliente, string sCantItems, string sTotalPed)
        {
            bool flag = false;
            int id = ctrlConversiones.toInt(sId);
            int cantItem = ctrlConversiones.toInt(sCantItems);
            string totP = ctrlConversiones.stringWithoutDolar(sTotalPed);
            double totalPed = ctrlConversiones.toDouble(totP);
            Pedido pedidoN = null;

            Cliente clienteObj = TratarCliente(cliente);
            ;

            if (menuPedido.Count > 0 && totalPed > 0 && cantItem > 0)
            {
                List<Plato> platosDelPedido = new List<Plato>(menuPedido);

                pedidoN = new Pedido(id, clienteObj, platosDelPedido, cantItem, totalPed);
                ListaPedidos.Add(pedidoN);
                flag = true;
            }
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
                flag = false;
            }
            return flag;

        }

        public void AutocompletarGrid(DataGridView dgvPedidos)
        {
            for (int i = 0; i < listaPedidos.Count; i++)
            {
                dgvPedidos.Rows.Add();
                dgvPedidos.Rows[i].Cells["idPedido"].Value = listaPedidos[i].CodPedido;
                dgvPedidos.Rows[i].Cells["clientePedido"].Value = listaPedidos[i].Cliente.Cedula;
                string menuPedidoS = string.Empty;
                foreach (Plato plato in listaPedidos[i].MenuSeleccionado)
                {
                    //Console.WriteLine(plato.ToString());
                    menuPedidoS += $"{plato.Descripcion}, ${plato.Precio}\n";
                }
                dgvPedidos.Rows[i].Cells["menuPedido"].Value = menuPedidoS;
                dgvPedidos.Rows[i].Cells["cantPedido"].Value = listaPedidos[i].CantidadProductos;
                dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {listaPedidos[i].TotalPedido}";

            }
        }

        public void BuscarPedido(string campo, string datoBuscar, DataGridView dgvPedidos)
        {
            List<Pedido> pedidosBuscar = new List<Pedido>();

            if (campo != null && datoBuscar != null)
            {
                if (campo.ToLower().Equals("id"))
                {
                    int idBuscar = ctrlConversiones.toInt(datoBuscar);
                    Pedido pedidoBuscar = ListaPedidos.Find(delBuscar => delBuscar.CodPedido == idBuscar);
                    if (pedidoBuscar != null)
                    {
                        pedidosBuscar.Add(pedidoBuscar);
                    }
                }
                else if (campo.ToLower().Equals("cliente"))
                {

                    pedidosBuscar = ListaPedidos.FindAll(delBuscar => delBuscar.Cliente.Cedula.Contains(datoBuscar));
                }
                else if (campo.ToLower().Equals("todos"))
                {
                    pedidosBuscar = ListaPedidos;
                }

                if (pedidosBuscar.Count > 0)
                {
                    dgvPedidos.Rows.Clear();
                    for (int i = 0; i < pedidosBuscar.Count; i++)
                    {
                        dgvPedidos.Rows.Add();
                        dgvPedidos.Rows[i].Cells["idPedido"].Value = pedidosBuscar[i].CodPedido;
                        dgvPedidos.Rows[i].Cells["clientePedido"].Value = pedidosBuscar[i].Cliente.Cedula;
                        string menuPedidoS = string.Empty;
                        foreach (Plato plato in menuPedido)
                        {
                            menuPedidoS += $"{plato.Descripcion}, ${plato.Precio}\n";
                        }
                        dgvPedidos.Rows[i].Cells["menuPedido"].Value = menuPedidoS;
                        dgvPedidos.Rows[i].Cells["cantPedido"].Value = pedidosBuscar[i].CantidadProductos;
                        dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {pedidosBuscar[i].TotalPedido}";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos que coincidan");
                }
            }
            else
            {
                MessageBox.Show("Datos no validos para realizar la busqueda");
            }
        }

        public void RestartPedido()
        {
            Cantidades = 0;
            TotalPed = 0;
            menuPedido.Clear();
        }

        public void EliminarRegistroCliente(string cedula)
        {
            Cliente clienteEliminar = listaClientes.Find(cliente => cliente.Cedula.Equals(cedula));
            if (clienteEliminar != null)
            {
                listaClientes.Remove(clienteEliminar);
                CtrlCliente.Clientes = listaClientes;
            }
        }

        public Cliente TratarCliente(string cliente)
        {
            string[] dataCliente = cliente.Trim().Split(',');
            string cedula = dataCliente[2].Trim();

            Cliente clientoObj = listaClientes.Find(delBuscar => delBuscar.Cedula.Equals(cedula));

            return clientoObj;
        }

        public Plato TratarPlato(string menu)
        {
            string[] data = menu.Trim().Split(',');
            int idP = ctrlConversiones.toInt(data[0]);

            Plato platoObj = listaPlatos.Find(delBuscar => delBuscar.IdPlato == idP);

            return platoObj;
        }
    }
}
