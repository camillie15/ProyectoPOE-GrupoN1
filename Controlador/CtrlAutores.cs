using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Datos;

namespace Controlador
{
    public class CtrlAutores
    {
        static List<Autor> listaAutores = new List<Autor>();
        DatosAutor datosAutor = new DatosAutor();

        public void Autores()
        {
            Autor camillie = new Autor(1, "Camillie Thais", "Ayovi Villafuerte", "0956334064", 21, "camillie.ayovivil@ug.edu.ec", true, "Pedido");
            datosAutor.IngresarAutor(camillie);
            Autor erick = new Autor(2, "Erick Alejandro", "Cordova Viteri", "1104949977", 22, "erick.cordovavit@ug.edu.ec", true, "Cliente");
            datosAutor.IngresarAutor(erick);
            Autor juliet = new Autor(3, "Juliet Diocelin", "Ortuño Sánchez", "0952355147", 21, "juliet.ortunosan@ug.edu.ec", true, "Factura");
            datosAutor.IngresarAutor(juliet);
            Autor mateo = new Autor(4, "Daniel Mateo", "Aguilar Villafuerte", "0956106207", 23, "daniel.aguilarvil@ug.edu.ec", true, "Plato");
            datosAutor.IngresarAutor(mateo);
        }

        public DataGridView AutocompletarGrid(DataGridView dgvAutores)
        {
            dgvAutores.Rows.Clear();
            listaAutores = datosAutor.ConsultarAutor();
            if (listaAutores.Count == 0)
            {
                Autores();
                listaAutores = datosAutor.ConsultarAutor();
            }
            for (int i = 0; i < listaAutores.Count; i++)
            {
                dgvAutores.Rows.Add();
                dgvAutores.Rows[i].Cells[0].Value = listaAutores[i].Nombre;
                dgvAutores.Rows[i].Cells[1].Value = listaAutores[i].Apellido;
                dgvAutores.Rows[i].Cells[2].Value = listaAutores[i].Cedula;
                dgvAutores.Rows[i].Cells[3].Value = listaAutores[i].Email;
                dgvAutores.Rows[i].Cells[4].Value = listaAutores[i].Modulo;

            }
            return dgvAutores;
        }

        public void Buscar(string moduloBuscar, DataGridView dgvAutores)
        {
            List<Autor> listaAutoresBusqueda = new List<Autor>();
            dgvAutores.Rows.Clear();
            if (!moduloBuscar.ToLower().Equals("todos"))
            {
                Autor autor = datosAutor.ConsultarPorModulo(moduloBuscar.ToLower());
                if (autor != null)
                {
                    listaAutoresBusqueda.Add(autor);
                }
            }
            else
            {
                listaAutoresBusqueda = listaAutores;
            }




            for (int i = 0; i < listaAutoresBusqueda.Count; i++)
            {
                dgvAutores.Rows.Add();
                dgvAutores.Rows[i].Cells[0].Value = listaAutoresBusqueda[i].Nombre;
                dgvAutores.Rows[i].Cells[1].Value = listaAutoresBusqueda[i].Apellido;
                dgvAutores.Rows[i].Cells[2].Value = listaAutoresBusqueda[i].Cedula;
                dgvAutores.Rows[i].Cells[3].Value = listaAutoresBusqueda[i].Email;
                dgvAutores.Rows[i].Cells[4].Value = listaAutoresBusqueda[i].Modulo;

            }
        }
    }
}
