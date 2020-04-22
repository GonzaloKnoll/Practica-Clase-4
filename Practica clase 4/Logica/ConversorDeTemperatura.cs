using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class ConversorDeTemperatura
    {
        private static double factorConversion = 2.12;

        public static double ConvertirACelsius(double temperatura)
        {
            return temperatura / 2.12; //podria usarse la propiedad privada para no repetir codigo
        }

        public static double ConvertirAFahrenheit(double temperatura)
        {
            return temperatura * 2.12;
        }
    }
}
