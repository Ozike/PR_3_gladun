using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Numeral_System
    {
        public string NumeralSystemCalc(int i, string number)
        {
            int numb = Convert.ToInt32(number);
            switch (i)
            {
                case 2:
                    return Convert.ToString(numb, 2).ToUpper();
                case 8:
                    return Convert.ToString(numb, 8).ToUpper();
                case 16:
                    return Convert.ToString(numb, 16).ToUpper();
                default:
                    return Convert.ToString("Данная система счисления не поддерживается.").ToUpper();

            }
        }
    }
}
