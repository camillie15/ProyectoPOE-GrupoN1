using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Controlador
{
    public class CtrlPedido
    {
        static int cantidades = 0;
        static double totalPed = 0;
        static List<Pedido> listaPedidos = new List<Pedido>();
        static List<MenuPedido> itemsPedido = new List<MenuPedido>();
        static List<MenuPedido> itemsPedidoAgg = null;

        List<Cliente> listaClientes = new List<Cliente>();
        List<Plato> listaPlatos = new List<Plato>();

        CtrlConversiones ctrlConversiones = new CtrlConversiones();
        DatosPedido datosPedido = new DatosPedido();
        DatosMenuPedido datosMenuPedido = new DatosMenuPedido();

        Conexion cn = new Conexion();
        public CtrlPedido()
        {
            CrearClientes();
            CrearPlato();
        }

        public static List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public static int Cantidades { get => cantidades; set => cantidades = value; }
        public static double TotalPed { get => totalPed; set => totalPed = value; }
        public static List<MenuPedido> ItemsPedido { get => itemsPedido; set => itemsPedido = value; }

        public void AgregarAlPedido(string idPedido, string pedidoSleccionado, string cantidadItem, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido, string tipo)
        {
            int cantItemAgregado = ctrlConversiones.toInt(cantidadItem);

            if (pedidoSleccionado != null && cantItemAgregado > 0)
            {
                Plato platoSeleccionado = listaPlatos.Find(delBuscar => delBuscar.IdPlato == TratarPlato(pedidoSleccionado).IdPlato);

                int idPedidoI = ctrlConversiones.toInt(idPedido);
                int idPed = platoSeleccionado.IdPlato;
                string descripcionPed = platoSeleccionado.Descripcion;
                double precioItem = platoSeleccionado.Precio;
                int cantidadItemPed = ctrlConversiones.toInt(cantidadItem);
                double totalPedidoItem = precioItem * cantidadItemPed;

                MenuPedido menuSeleccionado = new MenuPedido(idPedidoI, idPed, descripcionPed, cantidadItemPed, precioItem, totalPedidoItem);
                ItemsPedido.Add(menuSeleccionado);
                if (tipo.ToLower().Equals("editar"))
                {
                    itemsPedidoAgg.Add(menuSeleccionado);
                }
                string msj = datosMenuPedido.IngresarMenuPedido(menuSeleccionado);
                MessageBox.Show(msj);
                int i = dgvIngresoPedido.Rows.Add();

                dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = descripcionPed;
                dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = $"$ {precioItem}";
                dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = cantidadItemPed;
                dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = $"$ {totalPedidoItem}";

                Cantidades += menuSeleccionado.Cantidad;
                TotalPed += (menuSeleccionado.Precio * menuSeleccionado.Cantidad);

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
            listaClientes.Add(new Cliente("Cami", "Ayovi", "0983346789", 21, "camillie.com", true, 1, "Norte"));
            listaClientes.Add(new Cliente("Erick", "Cordova", "0955456789", 22, "erick.com", true, 2, "Norte"));
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

            if (sId != null && cliente != null && sCantItems != null && sTotalPed != string.Empty)
            {
                int id = ctrlConversiones.toInt(sId);
                int cantItem = ctrlConversiones.toInt(sCantItems);
                string totP = ctrlConversiones.stringWithoutDolar(sTotalPed);
                double totalPed = ctrlConversiones.toDouble(totP);
                Pedido pedidoN = null;

                Cliente clienteObj = TratarCliente(cliente);

                if (ItemsPedido.Count > 0 && totalPed > 0 && cantItem > 0)
                {
                    itemsPedidoAgg = new List<MenuPedido>(ItemsPedido);
                    pedidoN = new Pedido(id, clienteObj, itemsPedidoAgg, cantItem, totalPed);
                    ListaPedidos.Add(pedidoN);
                    string msj = datosPedido.IngresarPedido(pedidoN);
                    MessageBox.Show(msj);
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Error: Datos sin ingresar");
                    flag = false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar datos");
            }
            return flag;

        }

        public void AutocompletarGridPedido(DataGridView dgvPedidos)
        {
            for (int i = 0; i < listaPedidos.Count; i++)
            {
                if (i < listaPedidos.Count - 1)
                {
                    dgvPedidos.Rows.Add();
                }
                dgvPedidos.Rows[i].Cells["idPedido"].Value = listaPedidos[i].CodPedido;
                dgvPedidos.Rows[i].Cells["clientePedido"].Value = listaPedidos[i].Cliente.Cedula;
                string menuPedidoS = string.Empty;
                foreach (MenuPedido menu in listaPedidos[i].MenuSeleccionado)
                {
                    menuPedidoS += $"{menu.Descripcion}, ${menu.Precio}\n";
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
                        foreach (MenuPedido menu in pedidosBuscar[i].MenuSeleccionado)
                        {
                            menuPedidoS += $"{menu.Descripcion}, ${menu.Precio}\n";
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
            ItemsPedido.Clear();
        }

        public string idPedido()
        {
            return Convert.ToString(listaPedidos.Count + 1);
        }

        public void EliminarRegistroPedido()
        {
            Pedido pedidoELiminar = listaPedidos.Find(pedido => pedido.CodPedido == RetornarUltimoPedido().CodPedido);
            if (pedidoELiminar != null)
            {
                listaPedidos.Remove(pedidoELiminar);
            }
        }

        public Cliente TratarCliente(string cliente)
        {
            string[] dataCliente = cliente.Trim().Split(',');
            string cedula = dataCliente[2].Trim();

            Cliente clienteObj = listaClientes.Find(delBuscar => delBuscar.Cedula.Equals(cedula));

            return clienteObj;
        }

        public Plato TratarPlato(string menu)
        {
            string[] data = menu.Trim().Split(',');
            int idP = ctrlConversiones.toInt(data[0]);

            Plato platoObj = listaPlatos.Find(delBuscar => delBuscar.IdPlato == idP);

            return platoObj;
        }

        public void LlenarFrmEditarPedido(TextBox txtIdPedido, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido, ComboBox cmbCliente)
        {
            Pedido ultimoPedido = RetornarUltimoPedido();
            txtIdPedido.Text = ultimoPedido.CodPedido.ToString();


            AutocompletarGridMenuSeleccionado(dgvIngresoPedido);

            txtCantPedido.Text = ultimoPedido.CantidadProductos.ToString();
            txtTotPedido.Text = $"$ {ultimoPedido.TotalPedido.ToString()}";
        }

        public Pedido RetornarUltimoPedido()
        {
            Pedido pedido = null;
            if (ListaPedidos.Count >= 0)
            {
                pedido = ListaPedidos[ListaPedidos.Count - 1];
            }
            else
            {
                MessageBox.Show("No hay registros realizados en pedidos");
            }
            return pedido;
        }

        public bool EditarPedido(string sId, string cliente, string sCantItems, string sTotalPed)
        {
            bool flag = false;
            int id = ctrlConversiones.toInt(sId);
            int cantItem = ctrlConversiones.toInt(sCantItems);
            string totP = ctrlConversiones.stringWithoutDolar(sTotalPed);
            double totalPed = ctrlConversiones.toDouble(totP);

            Pedido pedidoN = RetornarUltimoPedido();
            Cliente clienteObj = null;
            if (itemsPedidoAgg.Count > 0 && totalPed > 0 && cantItem > 0)
            {
                if (cliente != string.Empty)
                {
                    clienteObj = RetornarUltimoPedido().Cliente;
                }
                else
                {
                    clienteObj = TratarCliente(cliente);
                }
                pedidoN = new Pedido(id, clienteObj, itemsPedidoAgg, cantItem, totalPed);
                ListaPedidos[ListaPedidos.IndexOf(RetornarUltimoPedido())] = (pedidoN);
                flag = true;
            }
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
                flag = false;
            }
            return flag;
        }

        public bool EliminarPlato(int rowIndex, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido)
        {
            bool flag = false;
            int idEliminar = 0;

            for (int i = 0; i < itemsPedidoAgg.Count; i++)
            {
                idEliminar = itemsPedidoAgg[i].IdMenu;
                if (itemsPedidoAgg[rowIndex].IdMenu == idEliminar)
                {
                    Cantidades = Cantidades - itemsPedidoAgg[i].Cantidad;
                    TotalPed = TotalPed - itemsPedidoAgg[i].ValorTotal;
                    txtCantPedido.Text = Cantidades.ToString();
                    txtTotPedido.Text = $"$ {TotalPed.ToString()}";
                    itemsPedidoAgg.Remove(itemsPedidoAgg[i]);
                    dgvIngresoPedido.Rows.RemoveAt(i);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public void AutocompletarGridMenuSeleccionado(DataGridView dgvIngresoPedido)
        {
            dgvIngresoPedido.Rows.Clear();
            for (int i = 0; i < itemsPedidoAgg.Count; i++)
            {
                dgvIngresoPedido.Rows.Add();
                dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = itemsPedidoAgg[i].Descripcion;
                dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = $"$ {itemsPedidoAgg[i].Precio}";
                dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = itemsPedidoAgg[i].Cantidad;
                dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = $"$ {itemsPedidoAgg[i].ValorTotal}";
            }
        }

        public void Conectar()
        {
            string msj = cn.Conectar();
            if (msj[0] == '1')
            {
                MessageBox.Show("Conexion Exitosa!");
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Ocurrio un error: " + msj);
            }
            cn.Desconectar();
        }
    }
}
