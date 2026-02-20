using System;
using System.Globalization;


    {
        Console.Write("Digite a venda média mensal: ");
        double vendaMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o preço atual do produto (R$): ");
        double precoAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double precoNovo;

        if (vendaMedia < 500 && precoAtual < 30.00)
        {
            precoNovo = precoAtual * 1.10; 
            Console.WriteLine($"Condição: Venda < 500 e Preço < R$30,00");
            Console.WriteLine($"Reajuste: +10%");
        }
        else if (vendaMedia >= 500 && precoAtual >= 30.00)
        {
            precoNovo = precoAtual * 0.80; 
            Console.WriteLine($"Condição: Venda >= 500 e Preço >= R$30,00");
            Console.WriteLine($"Reajuste: -20%");
        }
        else
        {
            precoNovo = precoAtual;
            Console.WriteLine($"O produto não se enquadra em nenhum critério de reajuste.");
        }

        Console.WriteLine($"Preço anterior: R$ {precoAtual:F2}");
        Console.WriteLine($"Preço novo:     R$ {precoNovo:F2}");
