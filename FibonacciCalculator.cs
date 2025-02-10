class FibonacciCalculator
{
    public static List<int> GenerateSeries(int depth)
    {
        List<int> series = new List<int>{0,1};

        for (int i = 2; i < depth; i++)
        {
            series.Add(series[i-1]+series[i-2]);
        }

        return series.Take(depth).ToList();
    }
}