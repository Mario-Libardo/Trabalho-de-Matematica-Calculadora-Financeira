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

            Console.Write(" Digite o valor financiado (PV): ");
            decimal pv = decimal.Parse(Console.ReadLine());

            Console.Write(" Digite a taxa de juros mensal (%): ");
            decimal taxa = decimal.Parse(Console.ReadLine());
            i = taxa / 100m;

            Console.Write(" Digite o número de parcelas (n): ");
            int n = int.Parse(Console.ReadLine());

            decimal financiamento = fs.CalcularFinanciamento(pv, i, n);

            Console.Clear();
            Console.WriteLine("\n ----/ Financiamento /----\n");
            Console.WriteLine($" Valor Financiado: {pv:C2}");
            Console.WriteLine($" Taxa de Juros: {taxa / 100m:P}");
            Console.WriteLine($" Tempo: {n} meses\n");
            Console.WriteLine("------------------------");
            Console.WriteLine($" Prestação Fixa: {financiamento:C2}");
            Console.WriteLine($" Total Pago: {(financiamento * n):C2}");
            Console.WriteLine($" Juros Totais Pagos: {(financiamento * n) - pv:C2}");

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
