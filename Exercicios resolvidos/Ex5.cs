using System;
using System.Globalization;


        Console.Write("Digite o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o salário por hora (R$): ");
        double salarioPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double horasNormaisMes = 40 * 4; 
        double salarioTotal;

        if (horasTrabalhadas <= horasNormaisMes)
        {
            salarioTotal = horasTrabalhadas * salarioPorHora;
        }
        else
        {
            double horasExtras = horasTrabalhadas - horasNormaisMes;
            double salarioHoraExtra = salarioPorHora * 1.5;

            salarioTotal = (horasNormaisMes * salarioPorHora) + (horasExtras * salarioHoraExtra);
        }

        Console.WriteLine($"Horas trabalhadas: {horasTrabalhadas}h");
        Console.WriteLine($"Horas normais: {horasNormaisMes}h");
        Console.WriteLine($"Horas extras: {Math.Max(0, horasTrabalhadas - horasNormaisMes)}h");
        Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
