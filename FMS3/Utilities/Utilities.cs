using System;
using FMS3.Data.Cache;

namespace FMS3.Utilities
{
    public class Utilities
    {
        public static int GetRandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        public static string GetRandomName()
        {
            var nameGen = RandomNameGenerator.NameGenerator.Generate(RandomNameGenerator.Gender.Male);

            return nameGen;
        }

        public static string GetWeekDisplay(int week)
        {
            if (week == 0)
            {
                return "Pre-Season";
            }
            if (week == (GameCache.NumberOfWeeksInSeason + 1))
            {
                return "Post-Season";
            }
            return "Week " + week;
        }
    }

    public static class IntegerExtensions
    {
        public static void TimesWithIndex(this int count, Action<int> action)
        {
            for (int i = 0; i < count; i++)
                action(i);
        }
    }
}
