using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class ConversorDeTemperatura
    {
        public static double ConvertirACelsius(double temperatura)
        {
            return temperatura / 2.12;
        }

        public static double ConvertirAFahrenheit(double temperatura)
        {
            return temperatura * 2.12;
        }
    }
}
