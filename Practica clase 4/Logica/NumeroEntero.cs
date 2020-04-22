using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroEntero
    {
        public decimal Numero { get; set; }
        /// <summary>
        /// Deberian ser 2 numeros enteros, no dos instancias de objeto.
        /// </summary>
        /// <param name="entero1"></param>
        /// <param name="entero2"></param>
        /// <returns></returns>
        public static NumeroEntero operator / (NumeroEntero entero1, NumeroEntero entero2)
        {
            NumeroEntero resultado = new NumeroEntero();
            resultado.Numero = Convert.ToDecimal(entero1.Numero / entero2.Numero);
            return resultado;
        }
    }
}
