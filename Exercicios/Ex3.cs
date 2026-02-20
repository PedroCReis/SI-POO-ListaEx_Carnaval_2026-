using System;
using System.Globalization;


        Console.Write("Digite sua altura (ex: 1.75): ");
        double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite seu sexo (M/F): ");
        char sexo = char.ToUpper(Console.ReadLine()[0]);

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * h) - 58;
            Console.WriteLine($"\nSexo: Masculino");
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * h) - 44.7;
            Console.WriteLine($"\nSexo: Feminino");
        }
        else
        {
            Console.WriteLine("Sexo inválido!");
            return;
        }

        Console.WriteLine($"Altura: {h}m");
        Console.WriteLine($"Peso ideal: {pesoIdeal:F2} kg");
