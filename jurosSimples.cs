using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    internal class jurosSimples
    {
        // Método que calcula apenas o valor dos juros (M)
        public decimal CalcularJuros(decimal C, decimal iPercent, decimal t)
        {
            // Converte a taxa em % para decimal (ex.: 5% -> 0.05)
            decimal i = iPercent / 100m;

            // Fórmula: M = C * i * t
            return C * i * t;
        }

        // Método que calcula o montante total (C + M)
        public decimal CalcularMontante(decimal C, decimal iPercent, decimal t)
        {
            decimal juros = CalcularJuros(C, iPercent, t);
            return C + juros;
        }
    }
}
