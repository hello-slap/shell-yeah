using Friday.Lib.Abstractions;

namespace Friday.Lib.MapReduce;
public class MapReduceDateCalculator : IDateCalculator
{
    public IEnumerable<DateTime> GetDates(DayOfWeek dayOfWeek, int dayOfMonth, int year)
    {
        return Enumerable.Range(1, 12)
            .Select(month => new DateTime(year, month, dayOfMonth))
            .Where(date => date.DayOfWeek == dayOfWeek);
    }
}
