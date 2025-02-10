class AverageCalculator
{
    public static double CalculateAverage(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            return 0; 

        return numbers.Average(); 
    }
}