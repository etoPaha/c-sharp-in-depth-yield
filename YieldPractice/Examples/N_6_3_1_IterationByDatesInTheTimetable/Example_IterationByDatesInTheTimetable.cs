namespace YieldPractice.Examples.N_6_3_1_IterationByDatesInTheTimetable;

public static class Example_IterationByDatesInTheTimetable
{
    public static void Start()
    {
        var range = Timetable.DateRange(DateTime.Now, DateTime.Now.AddDays(5));

        foreach (var day in range)
        {
            Console.WriteLine($"{day}");
        }
    } 
}