using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Erick Cordova Viteri
    public class Persona
    {
        public string nombre = string.Empty;
        public string apellido = string.Empty;
        private string cedula = string.Empty;
        public int edad = 0;
        public string email = string.Empty;
        bool estado = true;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public Persona(string nombre, string apellido, string cedula, int edad, string email, bool estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.edad = edad;
            this.email = email;
            this.estado = estado;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
