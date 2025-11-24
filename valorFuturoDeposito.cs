using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    internal class valorFuturoDeposito
    {
        public decimal CalcularVF(decimal P, decimal iPercent, decimal t)
        {
            decimal i = iPercent / 100m;

            // Fórmula: VF = (P * (1+i)^t) / i
            decimal VF = (P * (decimal)Math.Pow((double)(1 + i), (double)t)) / i;

            return VF;
        }
    }
}
