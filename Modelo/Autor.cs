using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Autor : Persona
    {
        int idAutor = 0;
        string modulo = string.Empty;
        public int IdAutor { get => idAutor; set => idAutor = value; }

        public string Modulo { get => modulo; set => modulo = value; }

        public Autor(int idAutor, string nombre, string apellido, string cedula, int edad, string email, bool estado, string modulo) : base(nombre, apellido, cedula, edad, email, estado)
        {
            IdAutor = idAutor;
            Modulo = modulo;
        }

        public override string ToString()
        {
            return $"{IdAutor}, {Nombre}, {apellido}, {Cedula}, {Modulo}";
        }
    }
}
