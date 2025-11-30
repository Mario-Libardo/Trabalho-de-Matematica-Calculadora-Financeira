using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    internal class jurosCompostos
    {
        public decimal CalcularMontante(decimal C, decimal iPercent, decimal t)
        {
            // Converte de porcentagem para decimal (5% -> 0.05)
            decimal i = iPercent / 100m;

            // Fórmula: M = C * (1 + i)^t
            decimal M = C * (decimal)Math.Pow((double)(1 + i), (double)t);

            return M;
        }
    }
}
