namespace SignalFromTheWoods.Domain.Calendar;

public static class UnlockPolicy
{
    public const int FirstDay = 1;
    public const int LastDay = 24;
    public const int CalendarMonth = 12;

    /// <summary>
    /// Returns the highest unlocked day (0 when the calendar has not opened yet).
    /// </summary>
    public static int GetMaxUnlockedDay(DateTime today)
    {
        if (today.Month < CalendarMonth)
        {
            return 0;
        }

        if (today.Month > CalendarMonth)
        {
            return LastDay;
        }

        return Math.Min(today.Day, LastDay);
    }

    public static bool IsDayUnlocked(int day, DateTime today) =>
        day is >= FirstDay and <= LastDay && day <= GetMaxUnlockedDay(today);
}
