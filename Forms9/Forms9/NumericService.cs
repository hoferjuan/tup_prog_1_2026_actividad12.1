using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms9
{
    internal class NumericService
    {
        private int acumulado = 0, cantidad = 0;

        public NumericService()
        {

        }
        public void RegistrarNumero(int numero)
        {
            acumulado += numero;
            cantidad++;
        }
        public int VerAcumulado()
        {
            return acumulado;
        }
        public int VerCantidad()
        {
            return cantidad;
        }
        public double CalcularPromedio()
        {
            if (cantidad > 0)
            {
                double promedio = (double)acumulado / cantidad;
                return promedio;
            }
            else { return 0; }
        }
    }
}
