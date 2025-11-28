using Calculadora_Financeira;
using System.Diagnostics;

Console.WriteLine(" ----/ Bem Vindo a Calculadora Financeira /----\n");
Console.Write("\n Pressione qualquer tecla para continuar... ");
Console.ReadKey();
while (true)
{
    Console.Clear();
    Console.Write(" -----/ Que Calculo Deseja Fazer? /-----\n\n Juros Simples.......(1)\n Juros Composto......(2)\n Depósito Mensal.....(3)\n Financiamento.......(4)\n Conversão de taxas..(5)\n\n Sair do Programa....(6)\n\n");
    string choise = Console.ReadLine();
    switch (choise)
    {
        case "1":
            Console.Clear();
            jurosSimples js = new jurosSimples();
            Console.WriteLine("\n ----/ Juros Simples /----\n");
            Console.Write(" Capital Inicial R$: ");
            decimal c = decimal.Parse(Console.ReadLine());

            Console.Write(" Taxa de Juros %: ");
            decimal i = decimal.Parse(Console.ReadLine());

            Console.Write(" Tempo (meses): ");
            decimal t = decimal.Parse(Console.ReadLine());

            decimal juros = js.CalcularJuros(c, i, t);
            decimal montante = js.CalcularMontante(c, i, t);

            Console.Clear();
            Console.WriteLine("\n ----/ Juros Simples /----\n");
            Console.WriteLine($" Capital Inicial R$: {c:C2}\n Taxa de Juros: {i / 100:P}\n Tempo: {t} meses");
            Console.WriteLine("------------------------");
            Console.WriteLine($" Juros: {juros:C2}\n Montante: {montante:C2}");

            Console.Write("\n Pressione qualquer tecla para sair... ");
            Console.ReadKey();

            break;

        case "2":
            Console.Clear();

            jurosCompostos jc = new jurosCompostos();
            Console.WriteLine("\n ----/ Juros Composto /----\n");

            Console.Write(" Capital Inicial R$: ");
            c = decimal.Parse(Console.ReadLine());

            Console.Write(" Taxa de Juros %: ");
            i = decimal.Parse(Console.ReadLine());

            Console.Write(" Tempo (meses): ");
            t = decimal.Parse(Console.ReadLine());

           
            montante = jc.CalcularMontante(c, i, t);
            juros = montante - c;

            Console.Clear();
            Console.WriteLine("\n ----/ Juros Composto /----\n");
            Console.WriteLine($" Capital Inicial: {c:C2}\n Taxa de Juros: {i / 100:P}\n Tempo: {t} meses");
            Console.WriteLine("------------------------");
            Console.WriteLine($" Juros Acumulados: {juros:C2}");
            Console.WriteLine($" Montante Final: {montante:C2}");

            Console.Write("\n Pressione qualquer tecla para sair... ");
            Console.ReadKey();
            break;

        case "3":

            Console.Clear();
            valorFuturoDeposito vf = new valorFuturoDeposito();
            Console.WriteLine("\n ----/ Deposito Mensal /----\n");
            Console.Write(" Valor do depósito mensal R$: ");
            decimal P = decimal.Parse(Console.ReadLine());

            Console.Write(" Taxa de juros % ao mês: ");
            i = decimal.Parse(Console.ReadLine());

            Console.Write(" Tempo (meses): ");
            t = decimal.Parse(Console.ReadLine());

            decimal valorFinal = vf.CalcularVF(P, i, t);

            Console.Clear();
            Console.WriteLine("\n ----/ Deposito Mensal /----\n");
            Console.WriteLine($" Depósito Mensal R$: {P:C2}\n Taxa de Juros: {i / 100:P}\n Tempo: {t} meses");
            Console.WriteLine("--------------------------");

            Console.WriteLine($" Valor Futuro R$: {valorFinal:C2}");

            Console.Write("\n Pressione qualquer tecla para sair... ");
            Console.ReadKey();
            break;

        case "4":

            Console.Clear();
            financiamentoSimples fs = new financiamentoSimples();
            Console.WriteLine("\n ----/ Finaciamento /----\n");

            Console.Write(" Valor da Financiado R$: ");
            decimal p = decimal.Parse(Console.ReadLine());

            Console.Write(" Taxa de Juros % ao mês: ");
            i = decimal.Parse(Console.ReadLine());

            Console.Write(" Tempo (meses): ");
            t = decimal.Parse(Console.ReadLine());

            decimal financiamento = fs.CalcularFinanciamento(p, i, t);
            
            Console.Clear();
            Console.WriteLine("\n ----/ Finaciamento /----\n");
            Console.WriteLine($" Valor Financiado: {p:C2}\n Taxa de Juros: {i / 100:P}\n Tempo: {t} meses\n");
            Console.WriteLine("------------------------");
            Console.WriteLine($" Prestação Fixa: {financiamento:C2}");
            Console.WriteLine($" Total Pago: {(financiamento * t):C2}");
            Console.WriteLine($" Juros Totais Pagos: {(financiamento * t) - p:C2}");

            Console.Write("\n Pressione qualquer tecla para sair... ");
            Console.ReadKey();

            break;

        case "5":
            while (true)
            {
                Console.Clear();
                conversaoTaxas ct = new conversaoTaxas();
                Console.WriteLine("\n ----/ Conversão de Taxas /----\n");
                Console.WriteLine(" Qual conversão deseja fazer?\n\n Anual -> Mensal...(1)\n Mensal -> Anual...(2) \n");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n ----/ Conversão de Taxas /----\n");
                    Console.Write("\n Digite a taxa anual (%): ");
                    decimal taxaAnual = decimal.Parse(Console.ReadLine());
                    decimal taxaMensal = ct.AnualParaMensal(taxaAnual);
                    Console.WriteLine($" Taxa equivalente mensal: {taxaMensal:F2}%");
                    Console.WriteLine("\n Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    break;
                }
                if (op == 2)
                {
                    
                    Console.Clear();
                    Console.WriteLine("\n ----/ Conversão de Taxas /----\n");
                    Console.Write("\n Digite a taxa mensal (%): ");
                    decimal taxaMes = decimal.Parse(Console.ReadLine());
                    decimal taxaAno = ct.MensalParaAnual(taxaMes);
                    Console.WriteLine($" Taxa equivalente anual: {taxaAno:F2}%");
                    Console.WriteLine("\n Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    break;
                }
                if (op != 1 || op != 2)
                {
                    
                  Console.WriteLine("!! Você digitou algo errado !! ");
                  Console.ReadKey();
                  break;
                
                }
            }
            break;

        case "6":
            Console.Clear();
            Console.Write("\n Tem certeza? s/n: ");
            string saida = Console.ReadLine();

            if (saida == "s")
            {
                Console.WriteLine("\n Fim do Programa!...  Até a Proxima.");
                return;
            }
            else
            {
                break;
            }
    }
}





/* Console.Clear();
Console.WriteLine("\n ----/ Financiamento /----\n");

Console.Write(" Valor Financiado R$: ");
decimal valor = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

Console.Write(" Taxa de Juros % ao mês: ");
decimal taxaPercent = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

Console.Write(" Tempo (meses): ");
decimal meses = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

// --------- CÁLCULO CORRETO (SEM MATH.POW) ---------

decimal i = taxaPercent / 100m;
Console.WriteLine(i);

// (1+i)^n 100% decimal
decimal fator = 1m;        // começa em 1
for (int x = 0; x < meses; x++)   // x = 0 até x = meses-1
{
    fator *= (1 + i);
    Console.WriteLine($"{fator},   meses: {x}");
}

decimal numerador = valor * i * fator;
decimal denominador = fator - 1;
decimal PMT = numerador / denominador;
*/
