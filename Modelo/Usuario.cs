using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Erick Cordova Viteri
    public class Usuario
    {
        public string nombre = string.Empty;
        public string apellido = string.Empty;
        public string cedula = string.Empty;
        public int edad = 0;
        public string email = string.Empty;
        public string userName = string.Empty;
        private string password = string.Empty;
        bool estado = true;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Usuario(string nombre, string apellido, string cedula, int edad, string email, string userName, string password, bool estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.edad = edad;
            this.email = email;
            this.userName = userName;
            this.password = password;
            this.estado = estado;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
