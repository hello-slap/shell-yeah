namespace Friday.Lib.Abstractions;
public interface IDateCalculator
{
    /// <summary>
    /// Gets all week days of a given year for the given day of the week and day of the month.
    /// For example: give me all friday 13th of 2022.
    /// </summary>
    /// <param name="year"></param>
    /// <param name="dayOfMonth"></param>
    /// <param name="dayOfWeek"></param>
    /// <returns></returns>
    IEnumerable<DateTime> GetDates(DayOfWeek dayOfWeek, int dayOfMonth, int year);
}
