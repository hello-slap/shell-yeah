using System;
using System.Diagnostics;
using Friday.Lib.Abstractions;
using Friday.Lib.MapReduce;

namespace Friday.CLI;
class Program
{
    static int Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("The year(s) must be passed as argument either as a single year or a range definition '<from>..<to>'!");
            return 1;
        }
        string yearString = args[0];
        // get the range of years
        string[] years = yearString.Split("..");
        if (years.Length > 2)
        {
            Console.WriteLine("Illegal range definition '" + yearString + "'. Only one range separator allowed!");
        }
        int from = Int32.Parse(years[0]);
        int to = from;
        if (years.Length == 2)
        {
            to = Int32.Parse(years[1]);
        }
        // use an algorithm to get the friday 13th dates of each year and print them
        IDateCalculator dateCalculator = new MapReduceDateCalculator();
        Console.WriteLine("Fridays to stay in bed:");
        foreach (var year in Enumerable.Range(from, to - from + 1))
        {
            IEnumerable<DateTime> fridays = dateCalculator.GetDates(DayOfWeek.Friday, 13, year);
            foreach (var friday in fridays)
            {
                Console.WriteLine(friday.ToString("dd.MM.yyyy"));
            }
        }
        return 0;
    }
}