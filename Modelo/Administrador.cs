using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Erick Cordova Viteri
    public class Usuario : Persona
    {
        int idUsuario = 0;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public Usuario(string nombre, string apellido, string cedula, int edad, string email, string userName, string password, bool estado, int idAdministrador) : base(nombre, apellido, cedula, edad, email, userName, password, estado)
        {
            this.idUsuario = idAdministrador;
        }

        public string ToString()
        {
            return base.ToString();
        }
    }
}
