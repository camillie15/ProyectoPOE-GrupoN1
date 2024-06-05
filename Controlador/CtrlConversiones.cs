using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
