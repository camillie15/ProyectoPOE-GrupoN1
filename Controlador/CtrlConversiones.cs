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
        public int toInt(string str)
        {
            int flag = 0;
            try
            {
                flag = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                flag = -1;
            }
            return flag;
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
