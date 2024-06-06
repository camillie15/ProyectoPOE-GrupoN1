using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlConversiones
    {
        public int toInt (string str)
        {
            int flag = 0;
            try
            {
                flag = Convert.ToInt32(str);
            }catch (Exception)
            {
                flag = -1;
            }
            return flag;
        }

        public double ConvertirDouble(string dato) 
        {
            double valor = -1;
            try
            {
                if (dato.Equals("") && string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("ERROR: DATO VACIO.\n");
                }
                else
                {
                    valor = Convert.ToDouble(dato, CultureInfo.InvariantCulture);
                }

                if (valor <= 0)
                {
                    Console.WriteLine("ERROR: DATO DEBE SER MAYOR A CERO.\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: DATO INVALIDO.\n");
               
            }
            return valor;
        }

        public void ValidarCaracterEspecial(object sender, KeyPressEventArgs e) // ENTRADA DE CARACTERES DEFINIDOS
        {
            char letra = e.KeyChar;
            List<char> caracteresPermitidos = new List<char> { ',', '.', '-', '+', '*', '#', '(', ')', ':', '<', '>', '/', '%', '\n', '\r', ' ', (char)Keys.Back };
            if (!char.IsLetterOrDigit(letra) && !caracteresPermitidos.Contains(letra))
            {
                e.Handled = true;
            }
        }

        public double toDouble(string str)
        {
            double flag = 0;
            try
            {
                flag = Convert.ToDouble(str);
            }
            catch (Exception)
            {
                flag = -1;
            }
            return flag;
        }

        public bool toBool(string str)
        {
            bool flag;
            try
            {
                if (str.ToLower().Trim().Equals("true"))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }

        public string stringWithoutDolar(string str)
        {
            string flag = string.Empty;
            try
            {
                flag = str.Substring(2);
            }
            catch (Exception)
            {
                flag = string.Empty;
            }
            return flag;
        }


    }
}
