namespace YieldPractice;

public class Example_YieldBreak
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
    
    public static IEnumerable<int> CountWithTimeLimit(DateTime limit)
    {
        for (int i = 0; i <= 100; i++)
        {
            // Остановка по завершении времени
            if (DateTime.Now >= limit)
            {
                yield break;
            }

            yield return i;
        }
    }
}