// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fibonacci Serisi Uygulaması");

int depth = UserInputHandler.GetFibonacciDepth();

Console.WriteLine($"Girdiğiniz Derinlik: {depth}");

List<int> fibonacciSeries = FibonacciCalculator.GenerateSeries(depth);

Console.WriteLine($"Fibonacci Serisi: {string.Join(", ", fibonacciSeries)}");

double average = AverageCalculator.CalculateAverage(fibonacciSeries);
        Console.WriteLine($"Ortalama: {average}");