using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class ControlEntradaTxt
    {

        //Control de tipo de caracteres aceptados = Solo letras
        public void ingresoSoloLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }


        //Control de tipo de caracteres aceptados = Solo numeros 
        public void ingresoSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        //Control de tipo de caracteres aceptados
        public void maximoDigitosNumericos(object sender, EventArgs e, int maxLength, TextBox txt)
        {
            if (txt.Text.Length > maxLength)
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                MessageBox.Show($"Solo se permiten {maxLength} digitos");
            }
        }

        public void ConvertirMayuscula(TextBox textBox)
        {
            int cursorPosicion = textBox.SelectionStart;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = cursorPosicion;
            return;
        }

    }
}
