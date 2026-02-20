
        double S = 1;

        for (int i = 2; i <= 50; i++)
        {
            S += (double)(2 * i - 1) / i;
        }

        Console.WriteLine($"S = {S:F4}");
    