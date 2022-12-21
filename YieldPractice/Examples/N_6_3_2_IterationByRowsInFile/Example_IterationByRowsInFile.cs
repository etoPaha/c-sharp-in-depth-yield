namespace YieldPractice.N_6_3_2_IterationByRowsInFile;

public class Example_IterationByRowsInFile
{
    public static void Start()
    {
        foreach (string line in FileUtil.ReadLines(@"Examples\N_6_3_2_IterationByRowsInFile\test.txt"))
        {
            Console.WriteLine(line);
        }
    }
}