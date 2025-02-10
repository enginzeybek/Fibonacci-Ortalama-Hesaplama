class UserInputHandler
{
    public static int GetFibonacciDepth()
    {
        int Depth;

        do
        {
            Console.WriteLine("Fibonacci serisi için derinlik girin: ");
        } while(!int.TryParse(Console.ReadLine(),out Depth) || Depth <= 0);

        return Depth;
    }
}