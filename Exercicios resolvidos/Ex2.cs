
        Console.Write("Digite A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Digite C: ");
        int C = int.Parse(Console.ReadLine());

        double R = Math.Pow(A + B, 2);
        double S = Math.Pow(B + C, 2);
        double D = (R + S) / 2;

        Console.WriteLine($"R = (A + B)² = {R}");
        Console.WriteLine($"S = (B + C)² = {S}");
        Console.WriteLine($"D = (R + S) / 2 = {D}");
