using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    internal class financiamentoSimples
    {
        public decimal CalcularFinanciamento(decimal p, decimal i, decimal t)
        {
            // Converter taxa percentual para decimal (ex: 5% → 0.05)
            decimal taxa = i / 100;

            // Aplicação da fórmula F = (P * (1 - (1 + i)^-t)) / i
            decimal fator = (decimal)(1 - Math.Pow((double)(1 + taxa), (double)-t));

            decimal F = (p * fator) / taxa;

            return F;
        }

    }
}
