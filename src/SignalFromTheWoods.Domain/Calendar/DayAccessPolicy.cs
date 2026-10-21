using SignalFromTheWoods.Domain.Progress;

namespace SignalFromTheWoods.Domain.Calendar;

/// <summary>
/// Combines the calendar date (how far the player may go today) with
/// progress (which days are done) into a status per day.
/// </summary>
public static class DayAccessPolicy
{
    public static DayStatus GetStatus(int day, GameProgress progress, int maxDateDay)
    {
        if (progress.IsCompleted(day))
        {
            return DayStatus.Completed;
        }

        if (day != progress.NextDay)
        {
            return DayStatus.LockedByOrder;
        }

        return day <= maxDateDay ? DayStatus.Playable : DayStatus.WaitingForDate;
    }

    public static bool CanPlay(int day, GameProgress progress, int maxDateDay) =>
        GetStatus(day, progress, maxDateDay) is DayStatus.Playable or DayStatus.Completed;
}
