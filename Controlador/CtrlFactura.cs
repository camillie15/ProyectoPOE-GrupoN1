using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.IO;

namespace Controlador
{
    public class CtrlFactura

    {
        CtrlConversiones v = new CtrlConversiones();
        //CtrlPedido p = new CtrlPedido();

        private static List<Factura> listafact = new List<Factura>();
        // lista pedido
        List<Pedido> listp = CtrlPedido.ListaPedidos;


        public static List<Factura> Listafact { get => listafact; set => listafact = value; }


        public void LlenaGrid(DataGridView dgvFactura)
        {
            int i = 0;

            if (listafact.Count > 0)
            {
                foreach (Factura f in Listafact)
                {
                    i = dgvFactura.Rows.Add();
                    dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
                    string cedulaCliente = f.Cliente.Cedula;
                    dgvFactura.Rows[i].Cells["ColCedula"].Value = cedulaCliente;
                    //dgvFactura.Rows[i].Cells["ColCedula"].Value = Cliente.Cedula;
                    dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
                    dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
                    dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
                }
            }
            else
            {
                MessageBox.Show("NO EXISTEN FACTURAS REGISTRADAS.");
            }
        }


        ////public string RetornarClientePedido()
        ////{
        ////    string cedula = string.Empty;
        ////    if (listp.Count > 0)
        ////    {
        ////        cedula = listp[listp.Count - 1].Cliente.Cedula;
        ////    }
        ////    else
        ////    {
        ////        cedula = string.Empty;
        ////    }
        ////    return cedula;
        ////}

        public string RetornarClientePedido()
        {
            string resultado = string.Empty;
            if (listp.Count > 0)
            {
                var ultimoCliente = listp[listp.Count - 1].Cliente;
                resultado = ultimoCliente.Nombre + ',' + ultimoCliente.Apellido + ',' + ultimoCliente.Cedula + ',' + ultimoCliente.Edad + ',' + ultimoCliente.Email + ',' + ultimoCliente.Estado + ','+ ultimoCliente.IdCliente + ',' + ultimoCliente.Direccion;
            }
            else
            {
                resultado = string.Empty;
            }
            return resultado;
        }

        // generar id de factura

        public string CrearId()
        {
            return (listafact.Count + 1).ToString();
        }


        public void IngresarFactura(string pIva, string pCliente, string pTotal, string pPedido, string pIdFactura, string pSubtotal)
        {
            double subtotal = v.toDouble(pSubtotal);
            double iva = v.toDouble(pIva);
            double total = v.toDouble(pTotal);
            int idFactura = v.toInt(pIdFactura);

            Pedido pedido = TratarPedido(pPedido);
            Cliente clienteObj = TratarCliente(pCliente);

            Factura factura = new Factura(iva, clienteObj, total, pedido, idFactura, subtotal);
            listafact.Add(factura);
        }

        public void Calcular(string pSubtotal, TextBox txtIva, TextBox txtTotal)
        {
            double subtotal;
            if (!double.TryParse(pSubtotal, out subtotal))
            {
                MessageBox.Show("Por favor, ingrese un subtotal válido.");
                return;
            }

            const double ValorIva = 0.15;
            double TotalIva = subtotal * ValorIva;
            double totalConIva = subtotal + TotalIva;

            txtIva.Text = TotalIva.ToString("");
            txtTotal.Text = totalConIva.ToString("");

        }

        //public void IngresarFactura(string pCliente, string pSubtotal, string pIva, string pTotal, string pedido, string pIdFactura, TextBox txtTotal, TextBox txtIva, TextBox txtSubtotal)
        //{
        //    double subtotal = v.ConvertirDouble(pSubtotal);
        //    double iva = v.ConvertirDouble(pIva);
        //    double total = v.ConvertirDouble(pTotal);
        //    int idFactura = v.toInt(pIdFactura);


        //    double sub = Convert.ToDouble(txtSubtotal.Text);
        //    double ValorIva = 0.15;
        //    double TotalIva = sub * ValorIva;
        //    double totalConIva = sub + TotalIva;


        //    txtIva.Text = TotalIva.ToString("");
        //    txtTotal.Text = totalConIva.ToString("");



        //    Factura factura = new Factura(TotalIva, pCliente, totalConIva, pedido, idFactura, sub);
        //    listafact.Add(factura);
        //}

        public void BuscarFactura(DataGridView dgvFactura, string columna)
        {
            dgvFactura.Rows.Clear();
            int i = 0;
            bool tf = false;
            foreach (Factura f in Listafact)
            {
                if (string.IsNullOrEmpty(columna) || f.Cliente.Cedula.Contains(columna))
                {
                    i = dgvFactura.Rows.Add();
                    dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
                    string cedulaCliente = f.Cliente.Cedula;
                    dgvFactura.Rows[i].Cells["ColCedula"].Value = cedulaCliente;
                    dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
                    dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
                    dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
                    tf = true;
                }
                else if (!tf)
                {
                    MessageBox.Show("No se encontraron resultados con los filtros proporcionados.");
                }

            }

        }
        public Cliente TratarCliente(string cliente)
        {
            string[] dataCliente = cliente.Trim().Split(',');
            if(dataCliente.Length < 8)
            {
                return null;
            }
            string nombre = dataCliente[0];
            string apellido = dataCliente[1];
            string cedula = dataCliente[2];
            int edad = v.toInt(dataCliente[3]);
            string email = dataCliente[4];
            bool estado = v.toBool(dataCliente[5]);
            int id = v.toInt(dataCliente[6]);
            string direccion = dataCliente[7];
            Cliente clientoObj = new Cliente(nombre, apellido, cedula, edad, email, estado, id, direccion);

            return clientoObj;

        }

        public Plato TratarPlato(string menu)
        {
            string[] dataPlato = menu.Trim().Split(',');
            if (dataPlato.Length < 6)
            {
                return null;
            }
            int id = v.toInt(dataPlato[0]);
            string nombre = dataPlato[1];
            string descripcion = dataPlato[2];
            string precioP = $"{dataPlato[3]},{dataPlato[4]}";
            double precio = v.toDouble(precioP.Substring(4));
            bool estado = v.toBool(dataPlato[5]);
            Plato platoObj = new Plato(id, nombre, descripcion, precio, estado);

            return platoObj;
        }

        public Pedido TratarPedido(string pedido)
        {
            string[] data = pedido.Trim().Split(',');

            int codPedido = v.toInt(data[0]);
            Cliente cliente = TratarCliente(data[1]);
            Plato plato = TratarPlato(data[2]);
            List<Plato> menuSeleccionado1 = new List<Plato> { plato };
            int cantidadProductos = v.toInt(data[3]);
            double totalPedido = v.toDouble(data[4]);
            Pedido pedidoObj = new Pedido(codPedido, cliente, menuSeleccionado1, cantidadProductos, totalPedido);

            return pedidoObj;
        }

    }

}