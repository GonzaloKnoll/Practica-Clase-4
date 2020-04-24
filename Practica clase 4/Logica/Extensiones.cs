using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Logica
{
    public static class Extensiones
    {
        public static int RetornarCantidadPalabras(this string cadena)
        {
            if (cadena != null)
            {
                string[] arraypalabras = cadena.Split(' ');
                return arraypalabras.Count();
            }
            return 0;
        }

        public static int RetornarCantidadPalabras(this string cadena, char separador)
        {
            string[] arraypalabras = cadena.Split(separador);
            return arraypalabras.Count();
        }

        public static decimal ObtenerMinutosEntreFechas(this DateTime fecha1, DateTime fecha2)
        {
            return Convert.ToDecimal((fecha1 - fecha2).TotalSeconds) / 60;
        }

        public static double ObtenerPromedio(this List<int> listanumeros)
        {
            return listanumeros.Sum() / listanumeros.Count();
        }

        public static int ObtenerMultiplicaciónParesImpares(this List<int> listanumeros)
        {
            return listanumeros.FindAll(x => x % 2 == 0).Sum() * (listanumeros.First(x => x % 2 != 0) * 2 + listanumeros.FindAll(x => x % 2 != 0).Sum() * (-1));
        }

        public static DateTime RetornarFecha(this string fecha)
        {
            DateTime fechaaretornar = new DateTime();
            try
            {
                fechaaretornar = DateTime.Parse(fecha);
            }
            catch (Exception)
            {
                fechaaretornar = DateTime.MinValue;
            }
            return fechaaretornar;
        }

        public static string InvertirCadena(this string cadena)
        {
            return cadena.Reverse().ToString();
        }

        public static string ConcatenarArrayString(this string[] arraystring, char separador)
        {
            return string.Join(separador.ToString(), arraystring);
        }

        public static int RestarNumeros(this int entero1, int entero2)
        {
            return entero1 - entero2;
        }

        public static bool ComprobarFormatoEmail(this string EmailAComprobar)
        {
            String Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(EmailAComprobar, Formato);
        }
    }
}