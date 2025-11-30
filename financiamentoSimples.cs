using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    public class financiamentoSimples
    {
        public decimal CalcularFinanciamento(decimal pv, decimal i, int n)
        {
            // Cálculo PRICE
            decimal pot = Pow(1 + i, n);
            decimal pmt = pv * (i * pot) / (pot - 1);

            return pmt;
        }

        private decimal Pow(decimal baseValue, int exponent)
        {
            decimal result = 1m;
            for (int x = 0; x < exponent; x++)
                result *= baseValue;
            return result;
        }
    }
    
}
