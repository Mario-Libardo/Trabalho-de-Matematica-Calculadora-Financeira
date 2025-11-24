using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    internal class conversaoTaxas
    {
        
            // Converte taxa anual para mensal
            public decimal AnualParaMensal(decimal iAnualPercent)
            {
                decimal iAnual = iAnualPercent / 100m;
                decimal iMensal = (decimal)Math.Pow((double)(1 + iAnual), 1.0 / 12.0) - 1;
                return iMensal * 100m; // retorna em %
            }

            // Converte taxa mensal para anual
            public decimal MensalParaAnual(decimal iMensalPercent)
            {
                decimal iMensal = iMensalPercent / 100m;
                decimal iAnual = (decimal)Math.Pow((double)(1 + iMensal), 12) - 1;
                return iAnual * 100m; // retorna em %
            }
        
    }
}
