using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosAutor
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = null;
        public List<Autor> ConsultarAutor()
        {
            List<Autor> listaAutores = new List<Autor>();
            SqlDataReader dr = null;
            Autor autor = null;

            string comando = "SELECT idAutor, nombres, apellidos, cedula, email, modulo, edad, estado FROM Autor";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    autor = new Autor(0, " ", " ", " ", 0, " ", true, " ");
                    autor.IdAutor = Convert.ToInt32(dr["idAutor"]);
                    autor.Nombre = dr["nombres"].ToString().TrimEnd();
                    autor.Apellido = dr["apellidos"].ToString().TrimEnd();
                    autor.Cedula = dr["cedula"].ToString().TrimEnd();
                    autor.Email = dr["email"].ToString().TrimEnd();
                    autor.Modulo = dr["modulo"].ToString().TrimEnd();
                    autor.Edad = Convert.ToInt32(dr["edad"]);
                    autor.Estado = Convert.ToInt32(dr["estado"]) == 1 ? true : false;

                    listaAutores.Add(autor);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaAutores;
        }

        public Autor ConsultarPorModulo(string moduloBuscar)
        {
            SqlDataReader dr = null;
            Autor autor = null;

            string comando = $"SELECT idAutor, nombres, apellidos, cedula, email, modulo, edad, estado FROM Autor WHERE modulo = '{moduloBuscar}'";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    autor = new Autor(0, " ", " ", " ", 0, " ", true, " ");
                    autor.IdAutor = Convert.ToInt32(dr["idAutor"]);
                    autor.Nombre = dr["nombres"].ToString().TrimEnd();
                    autor.Apellido = dr["apellidos"].ToString().TrimEnd();
                    autor.Cedula = dr["cedula"].ToString().TrimEnd();
                    autor.Email = dr["email"].ToString().TrimEnd();
                    autor.Modulo = dr["modulo"].ToString().TrimEnd();
                    autor.Edad = Convert.ToInt32(dr["edad"]);
                    autor.Estado = Convert.ToInt32(dr["estado"]) == 1 ? true : false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return autor;
        }

        public void IngresarAutor(Autor autor)
        {
            string comando = $"INSERT INTO Autor(nombres, apellidos, cedula, email, modulo, edad, estado)" +
               $"VALUES('{autor.Nombre}', '{autor.Apellido}', '{autor.Cedula}', '{autor.Email}', '{autor.Modulo}', {autor.Edad}, 1)";
            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
                Console.WriteLine("Autor ingresado en la DB de manera exitosa");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error en el ingreso a la DB \n{ex}");
            }
        }
    }
}

