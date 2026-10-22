using SignalFromTheWoods.Application.Abstractions;
using SignalFromTheWoods.Domain.Calendar;
using SignalFromTheWoods.Domain.Progress;

namespace SignalFromTheWoods.Application.Services;

/// <summary>
/// Holds the player's progress in memory and persists changes through <see cref="IProgressStore"/>.
/// </summary>
public class ProgressService(IProgressStore store, UnlockService unlock)
{
    private GameProgress? _progress;

    public GameProgress Progress => _progress ?? throw new InvalidOperationException("Call EnsureLoadedAsync first.");

    public async Task EnsureLoadedAsync()
    {
        _progress ??= await store.LoadAsync();
    }

    public DayStatus GetStatus(int day) =>
        DayAccessPolicy.GetStatus(day, Progress, unlock.MaxUnlockedDay);

    public bool CanPlay(int day) =>
        DayAccessPolicy.CanPlay(day, Progress, unlock.MaxUnlockedDay);

    public async Task CompleteDayAsync(int day)
    {
        Progress.MarkCompleted(day);
        await store.SaveAsync(Progress);
    }

    /// <summary>Sets progress so that the given day is the next one to play (for testing).</summary>
    public async Task JumpToDayAsync(int day)
    {
        Progress.JumpTo(day);
        await store.SaveAsync(Progress);
    }

    public async Task ResetAsync()
    {
        Progress.Reset();
        await store.SaveAsync(Progress);
    }

    /// <summary>Reveals the next hint
    public async Task<int> RevealNextHintAsync(int day, int totalHints)
    {
        var revealed = Math.Min(Progress.GetHintsRevealed(day) + 1, totalHints);
        Progress.SetHintsRevealed(day, revealed);
        await store.SaveAsync(Progress);
        return revealed;
    }
}
