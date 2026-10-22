using SignalFromTheWoods.Application.Abstractions;
using SignalFromTheWoods.Domain.Calendar;

namespace SignalFromTheWoods.Application.Services;

public class UnlockService(IClock clock)
{
    private bool _isDemoMode;

    public event Action? DemoModeChanged;

    public bool IsDemoMode
    {
        get => _isDemoMode;
        set
        {
            if (_isDemoMode == value)
            {
                return;
            }

            _isDemoMode = value;
            DemoModeChanged?.Invoke();
        }
    }

    public bool HasCalendarOpened => MaxUnlockedDay >= UnlockPolicy.FirstDay;

    public int MaxUnlockedDay =>
        IsDemoMode ? UnlockPolicy.LastDay : UnlockPolicy.GetMaxUnlockedDay(clock.Today);

    public bool IsUnlocked(int day) =>
        day is >= UnlockPolicy.FirstDay and <= UnlockPolicy.LastDay && day <= MaxUnlockedDay;
}
