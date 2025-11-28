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
            // taxa em decimal (ex: 4% → 0,04)
            decimal i = iPercent / 100m;

            // VF = P * [ (1 + i)^t - 1 ] / i
            decimal fator = (decimal)Math.Pow((double)(1 + i), (double)t) - 1m;

            decimal VF = P * (fator / i);

            return VF;
        }
    }
}
