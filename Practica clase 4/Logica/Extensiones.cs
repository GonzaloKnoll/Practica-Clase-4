using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Extensiones
    {
        public static int RetornarCantidadPalabras(this string cadena)
        {
            string[] arraypalabras = cadena.Split(' ');
            return arraypalabras.Count();
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
    }
}