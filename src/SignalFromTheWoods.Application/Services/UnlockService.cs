using SignalFromTheWoods.Application.Abstractions;
using SignalFromTheWoods.Domain.Calendar;

namespace SignalFromTheWoods.Application.Services;

public class UnlockService(IClock clock)
{
    public bool IsDemoMode { get; set; }

    public bool HasCalendarOpened => MaxUnlockedDay >= UnlockPolicy.FirstDay;

    public int MaxUnlockedDay =>
        IsDemoMode ? UnlockPolicy.LastDay : UnlockPolicy.GetMaxUnlockedDay(clock.Today);

    public bool IsUnlocked(int day) =>
        day is >= UnlockPolicy.FirstDay and <= UnlockPolicy.LastDay && day <= MaxUnlockedDay;
}
