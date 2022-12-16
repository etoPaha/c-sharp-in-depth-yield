namespace YieldPractice;

public class Example_Yield
{
    static readonly string Padding = new string(' ', 30);

    private static IEnumerable<int> CreateEnumerable()
    {
        Console.WriteLine($"{Padding}Start of CreateEnumerable()");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{Padding}About to yield {i}");

            yield return i;

            Console.WriteLine($"{Padding}After yield");
        }

        Console.WriteLine($"{Padding}Yielding final value");

        yield return -1;

        Console.WriteLine($"{Padding}End of CreateEnumerable()");
    }
    
    public static void Start()
    {
        IEnumerable<int> iterable = CreateEnumerable();
        IEnumerator<int> iterator = iterable.GetEnumerator();

        Console.WriteLine("Starting to iterate");

        while (true)
        {
            Console.WriteLine("Calling MoveNext()...");

            bool result = iterator.MoveNext();

            Console.WriteLine($"... MoveNext result = {result}");

            if (!result)
            {
                break;
            }

            Console.WriteLine("Fetching Current ...");

            Console.WriteLine($"... Current result = {iterator.Current}");
        }
    } 
}