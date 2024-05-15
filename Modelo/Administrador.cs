using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Erick Cordova Viteri
    public class Administrador : Usuario
    {
        int idAdministrador = 0;
        public int IdAdministrador { get => idAdministrador; set => idAdministrador = value; }

        public Administrador(string nombre, string apellido, string cedula, int edad, string email, string userName, string password, bool estado, int idAdministrador) : base(nombre, apellido, cedula, edad, email, userName, password, estado)
        {
            this.idAdministrador = idAdministrador;
        }

        public string ToString()
        {
            return base.ToString();
        }
    }
}
