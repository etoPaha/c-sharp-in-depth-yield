namespace YieldPractice.Examples.N_6_3_1_IterationByDatesInTheTimetable;

public class Timetable
{
    public static IEnumerable<DateTime> DateRange(DateTime startDate, DateTime endDate)
    {
        for (DateTime day = startDate;
             day <= endDate;
             day = day.AddDays(1))
        {
            yield return day;
        }
    }
}