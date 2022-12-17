namespace YieldPractice;

public class Example_YieldBreak_Finally
{
    public static void Start()
    {
        DateTime stop = DateTime.Now.AddSeconds(2);

        foreach (int i in CountWithTimeLimit(stop))
        {
            Console.WriteLine($"Received {i}");
            Thread.Sleep(300);
        }
    }

    private static IEnumerable<int> CountWithTimeLimit(DateTime limit)
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                if (DateTime.Now >= limit)
                {
                    yield break;
                }

                yield return i;
            }
        }
        finally
        {
            Console.WriteLine("Stopping!");
        }
    }
}