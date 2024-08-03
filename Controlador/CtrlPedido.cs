using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.Data.SqlClient;

namespace Controlador
{
    public class CtrlPedido
    {
        static int cantidades = 0;
        static double totalPed = 0;

        CtrlConversiones ctrlConversiones = new CtrlConversiones();
        CtrlPlato ctrlPlato = new CtrlPlato();
        DatosPedido datosPedido = new DatosPedido();
        DatosPlatoPedido datosPlatoPedido = new DatosPlatoPedido();
        DatosCliente datosCliente = new DatosCliente();
        DatosPlato datosPlato = new DatosPlato();

        //static List<Pedido> listaPedidos = new List<Pedido>();
        static List<PlatoPedido> platosPedidos = new List<PlatoPedido>();
        //static List<PlatoPedido> itemsPedidoAgg = null;

        static List<Cliente> listaClientesDB = null;
        static List<Plato> listaPlatosDB = null;

        static List<Pedido> listaPedidosDB = null;
        static List<PlatoPedido> listaPlatosPedidosDB = null;

        Conexion cn = new Conexion();
        public CtrlPedido()
        {
            listaClientesDB = datosCliente.ObtenerClientes();
            listaPlatosDB = ctrlPlato.SeleccionarPlato();
        }

        public static int Cantidades { get => cantidades; set => cantidades = value; }
        public static double TotalPed { get => totalPed; set => totalPed = value; }
        public static List<PlatoPedido> PlatosPedidos { get => platosPedidos; set => platosPedidos = value; }
        static public List<Pedido> ListaPedidosDB { get => listaPedidosDB; set => listaPedidosDB = value; }

        public void AgregarAlPedido(string idPedidoS, string pedidoSleccionado, string cantidadItem, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido, string tipo)
        {
            int cantItemAgregado = ctrlConversiones.toInt(cantidadItem);

            if (pedidoSleccionado != null && cantItemAgregado > 0)
            {
                Plato platoSeleccionado = listaPlatosDB.Find(delBuscar => delBuscar.IdPlato == TratarPlato(pedidoSleccionado).IdPlato);

                int idPlatoPedido = platoSeleccionado.IdPlato;
                int idPedido = ctrlConversiones.toInt(idPedidoS);
                string descripcionPed = platoSeleccionado.Descripcion;
                double precioItem = platoSeleccionado.Precio;
                int cantidadItemPed = ctrlConversiones.toInt(cantidadItem);
                double totalPedidoItem = precioItem * cantidadItemPed;

                PlatoPedido menuSeleccionado = new PlatoPedido(idPlatoPedido, idPedido, descripcionPed, cantidadItemPed, precioItem, totalPedidoItem, true);
                PlatosPedidos.Add(menuSeleccionado);
                if (tipo.ToLower().Equals("editar"))
                {
                    string msjMP = datosPlatoPedido.IngresarPlatoPedido(menuSeleccionado);
                    //MessageBox.Show(msjMP);
                }
                int i = dgvIngresoPedido.Rows.Add();
                dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = descripcionPed;
                dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = $"$ {precioItem}";
                dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = cantidadItemPed;
                dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = $"$ {totalPedidoItem}";

                Cantidades += menuSeleccionado.Cantidad;
                TotalPed += (menuSeleccionado.Precio * menuSeleccionado.Cantidad);

                txtCantPedido.Text = Cantidades.ToString();
                txtTotPedido.Text = $"$ {TotalPed.ToString()}";


                listaPlatosPedidosDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(idPedido);
            }
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
            }
        }

        public void LlenarCmb(ComboBox cmbData, string tipo)
        {
            if (tipo.ToLower().Equals("cliente"))
            {
                foreach (Cliente cliente in listaClientesDB)
                {
                    cmbData.Items.Add($"{cliente.Nombre}, {cliente.Apellido}, {cliente.Cedula}");
                }
            }
            else if (tipo.ToLower().Equals("plato"))
            {

                foreach (Plato plato in listaPlatosDB)
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

                if (PlatosPedidos.Count > 0 && totalPed > 0 && cantItem > 0)
                {
                    pedidoN = new Pedido(id, clienteObj, cantItem, totalPed, true);
                    //ListaPedidos.Add(pedidoN);
                    string msj = datosPedido.IngresarPedido(pedidoN);
                    listaPedidosDB = datosPedido.ConsultarPedidos();

                    if (msj.ToLower().Equals("pedido ingresado en la db de manera exitosa"))
                    {
                        foreach (PlatoPedido platoSeleccionado in PlatosPedidos)
                        {
                            platoSeleccionado.IdPedido = ListaPedidosDB[ListaPedidosDB.Count - 1].CodPedido;
                            string msjMP = datosPlatoPedido.IngresarPlatoPedido(platoSeleccionado);
                            //MessageBox.Show(msjMP);
                        }
                        listaPedidosDB = datosPedido.ConsultarPedidos();
                    }
                    //MessageBox.Show(msj);

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
            ListaPedidosDB = datosPedido.ConsultarPedidos();

            dgvPedidos.Rows.Clear();

            if (ListaPedidosDB != null)
            {
                foreach (Pedido pedido in ListaPedidosDB)
                {
                    if (pedido.Estado == true)
                    {
                        int i = dgvPedidos.Rows.Add();

                        if (i >= 0 && i < dgvPedidos.Rows.Count)
                        {
                            dgvPedidos.Rows[i].Cells["idPedido"].Value = pedido.CodPedido;
                            dgvPedidos.Rows[i].Cells["clientePedido"].Value = pedido.Cliente.Cedula;

                            List<PlatoPedido> listaPlatoPedidoByIdDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(pedido.CodPedido);
                            string platosPedidosS = string.Empty;

                            foreach (PlatoPedido platoPedido in listaPlatoPedidoByIdDB)
                            {
                                if (platoPedido.Estado == true)
                                {
                                    platosPedidosS += $"{platoPedido.Descripcion}, ${platoPedido.Precio}\n";

                                }
                            }

                            dgvPedidos.Rows[i].Cells["menuPedido"].Value = platosPedidosS;
                            dgvPedidos.Rows[i].Cells["cantPedido"].Value = pedido.CantidadProductos;
                            dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {pedido.TotalPedido}";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay pedidos registrados, ingrese un nuevo pedido");
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
                    //Pedido pedidoBuscar = ListaPedidosDB.Find(delBuscar => delBuscar.CodPedido == idBuscar);
                    Pedido pedidoBuscar = datosPedido.ConsultarPedidoPorId(idBuscar);
                    if (pedidoBuscar != null)
                    {
                        pedidosBuscar.Add(pedidoBuscar);
                    }
                }
                else if (campo.ToLower().Equals("cliente"))
                {
                    //pedidosBuscar = ListaPedidosDB.FindAll(delBuscar => delBuscar.Cliente.Cedula.Contains(datoBuscar));
                    Cliente cliente = listaClientesDB.Find(delBuscar => delBuscar.Cedula.Equals(datoBuscar));
                    pedidosBuscar = datosPedido.ConsultarPedidosPorCliente(cliente.IdCliente);
                    Console.WriteLine(datoBuscar);
                }
                else if (campo.ToLower().Equals("todos"))
                {
                    pedidosBuscar = ListaPedidosDB;
                }

                if (pedidosBuscar.Count > 0)
                {
                    dgvPedidos.Rows.Clear();
                    for (int i = 0; i < pedidosBuscar.Count; i++)
                    {
                        if (i < pedidosBuscar.Count - 1)
                        {
                            dgvPedidos.Rows.Add();
                        }
                        dgvPedidos.Rows[i].Cells["idPedido"].Value = pedidosBuscar[i].CodPedido;
                        dgvPedidos.Rows[i].Cells["clientePedido"].Value = pedidosBuscar[i].Cliente.Cedula;

                        List<PlatoPedido> listaPlatoPedidoByIdDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(pedidosBuscar[i].CodPedido);
                        string platosPedidosS = string.Empty;
                        foreach (PlatoPedido platoPedido in listaPlatoPedidoByIdDB)
                        {
                            if (platoPedido.Estado == true)
                            {
                                platosPedidosS += $"{platoPedido.Descripcion}, ${platoPedido.Precio}\n";
                            }
                        }

                        dgvPedidos.Rows[i].Cells["menuPedido"].Value = platosPedidosS;
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
            PlatosPedidos.Clear();
        }

        public string idPedido()
        {
            return Convert.ToString(datosPedido.UltimoIdPedidoDB() + 1);
        }

        public void EliminarRegistroPedido()
        {
            datosPedido.EliminarPedido(datosPedido.UltimoIdPedidoDB());
        }

        public Cliente TratarCliente(string cliente)
        {
            string[] dataCliente = cliente.Trim().Split(',');
            string cedula = dataCliente[2].Trim();

            Cliente clienteObj = listaClientesDB.Find(delBuscar => delBuscar.Cedula.Equals(cedula));

            return clienteObj;
        }

        public Plato TratarPlato(string menu)
        {
            string[] data = menu.Trim().Split(',');
            int idP = ctrlConversiones.toInt(data[0]);

            Plato platoObj = listaPlatosDB.Find(delBuscar => delBuscar.IdPlato == idP);

            return platoObj;
        }

        public void LlenarFrmEditarPedido(TextBox txtIdPedido, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido, ComboBox cmbCliente)
        {
            Pedido ultimoPedido = ListaPedidosDB[ListaPedidosDB.Count - 1];
            txtIdPedido.Text = ultimoPedido.CodPedido.ToString();

            listaPlatosPedidosDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(ultimoPedido.CodPedido);

            AutocompletarGridMenuSeleccionado(dgvIngresoPedido);

            txtCantPedido.Text = ultimoPedido.CantidadProductos.ToString();
            txtTotPedido.Text = $"$ {ultimoPedido.TotalPedido.ToString()}";
        }

        //public Pedido RetornarUltimoPedido()
        //{
        //    Pedido pedido = null;
        //    if (ListaPedidosDB.Count >= 0)
        //    {
        //        pedido = ListaPedidosDB[ListaPedidosDB.Count - 1];
        //    }
        //    else
        //    {
        //        MessageBox.Show("No hay registros realizados en pedidos");
        //    }
        //    return pedido;
        //}

        public bool EditarPedido(string sId, string cliente, string sCantItems, string sTotalPed)
        {
            bool flag = false;
            int id = ctrlConversiones.toInt(sId);
            int cantItem = ctrlConversiones.toInt(sCantItems);
            string totP = ctrlConversiones.stringWithoutDolar(sTotalPed);
            double totalPed = ctrlConversiones.toDouble(totP);

            Pedido pedidoN = ListaPedidosDB[ListaPedidosDB.Count - 1];
            Cliente clienteObj = null;

            if (listaPlatosPedidosDB.Count > 0 && totalPed > 0 && cantItem > 0)
            {
                if (cliente != string.Empty)
                {
                    clienteObj = ListaPedidosDB[ListaPedidosDB.Count - 1].Cliente;
                }
                else
                {
                    clienteObj = TratarCliente(cliente);
                }
                pedidoN = new Pedido(id, clienteObj, cantItem, totalPed, true);

                string msjActualizar = datosPedido.ActualizarPedido(pedidoN, id);
                MessageBox.Show(msjActualizar);

                ListaPedidosDB = datosPedido.ConsultarPedidos();

                flag = true;
            }
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
                flag = false;
            }
            return flag;
        }

        public bool EliminarPlatoPedido(int rowIndex, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido, string sId)
        {
            bool flag = false;
            int idEliminar = 0;
            int idPedido = ctrlConversiones.toInt(sId);

            listaPlatosPedidosDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(idPedido);

            for (int i = 0; i < listaPlatosPedidosDB.Count; i++)
            {
                idEliminar = listaPlatosPedidosDB[i].IdPlato;
                if (listaPlatosPedidosDB[rowIndex].IdPlato == idEliminar && listaPlatosPedidosDB[rowIndex].IdPedido == idPedido)
                {
                    Cantidades = Cantidades - listaPlatosPedidosDB[i].Cantidad;
                    TotalPed = TotalPed - listaPlatosPedidosDB[i].ValorTotal;
                    txtCantPedido.Text = Cantidades.ToString();
                    txtTotPedido.Text = $"$ {TotalPed.ToString()}";
                    //listaPlatosPedidosDB.Remove(listaPlatosPedidosDB[i]);
                    datosPlatoPedido.EliminarPlatoPedido(idEliminar, idPedido);

                    listaPlatosPedidosDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(idPedido);
                    AutocompletarGridMenuSeleccionado(dgvIngresoPedido);
                    //dgvIngresoPedido.Rows.RemoveAt(i);

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
            for (int i = 0; i < listaPlatosPedidosDB.Count; i++)
            {
                if (listaPlatosPedidosDB[i].Estado == true)
                {
                    dgvIngresoPedido.Rows.Add();
                    dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = listaPlatosPedidosDB[i].Descripcion;
                    dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = $"$ {listaPlatosPedidosDB[i].Precio}";
                    dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = listaPlatosPedidosDB[i].Cantidad;
                    dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = $"$ {listaPlatosPedidosDB[i].ValorTotal}";
                }
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
