namespace YieldPractice;

public class Example
{
    public static void Start()
    {
        object[] values = { "a", "b", "c", "d", "e", "f"};
        IterationSample collection = new IterationSample(values, 3);

        foreach (object x in collection)
        {
            Console.WriteLine(x);            
        }
    } 
}