using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente : Usuario
    {
        int idCliente = 0;
        string direccion = string.Empty;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Cliente(string nombre, string apellido, string cedula, int edad, string email, string userName, string password, bool estado, int idCliente, string direccion) : base(nombre, apellido, cedula, edad, email, userName, password, estado)
        {
            this.idCliente = idCliente;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
