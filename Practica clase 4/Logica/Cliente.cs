using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int CUIT { get; set; }
        public double Saldo { get; set; }

        public static Cliente operator -(Cliente c1, Cliente c2)
        {
            Cliente nuevoCliente = new Cliente();
            if (c1.CUIT == c2.CUIT)
            {
                nuevoCliente.Saldo = c1.Saldo - c2.Saldo;
            }
            else
            {
                if (c1.Saldo<c2.Saldo)
                {
                    nuevoCliente.Saldo = c1.Saldo;
                }
                else
                {
                    nuevoCliente.Saldo = c2.Saldo;
                }
            }
            return nuevoCliente;
        }
    }
}
