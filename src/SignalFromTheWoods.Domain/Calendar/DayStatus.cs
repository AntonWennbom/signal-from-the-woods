namespace SignalFromTheWoods.Domain.Calendar;

public enum DayStatus
{
    /// <summary>The day has been completed.</summary>
    Completed,

    /// <summary>The day can be played right now.</summary>
    Playable,

    /// <summary>All previous days are done, but the calendar date has not reached this day yet.</summary>
    WaitingForDate,

    /// <summary>An earlier day must be completed first.</summary>
    LockedByOrder
}
