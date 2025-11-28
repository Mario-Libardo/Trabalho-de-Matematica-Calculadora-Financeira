using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    internal class financiamentoSimples
    {
        public decimal CalcularFinanciamento(decimal valor, decimal taxaPercent, decimal meses)
        {
            decimal i = taxaPercent / 100m;   // taxa decimal
            decimal fator = (decimal)Math.Pow((double)(1 + i), (double)meses);

            decimal PMT = valor * (i * fator) / (fator - 1);
            return Math.Round(PMT, 2);
        }

    }
}
