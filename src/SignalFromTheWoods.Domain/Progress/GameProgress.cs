namespace SignalFromTheWoods.Domain.Progress;

public class GameProgress
{
    private readonly HashSet<int> _completedDays = [];
    private readonly Dictionary<int, int> _hintsRevealed = [];

    public IReadOnlySet<int> CompletedDays => _completedDays;

    public IReadOnlyDictionary<int, int> HintsRevealed => _hintsRevealed;

    public int CompletedCount => _completedDays.Count;

    /// <summary>
    /// The first day in order that has not been completed (25 when everything is done).
    /// </summary>
    public int NextDay
    {
        get
        {
            var day = 1;
            while (_completedDays.Contains(day))
            {
                day++;
            }

            return day;
        }
    }

    public bool IsCompleted(int day) => _completedDays.Contains(day);

    public void MarkCompleted(int day) => _completedDays.Add(day);

    public int GetHintsRevealed(int day) => _hintsRevealed.GetValueOrDefault(day);

    public void SetHintsRevealed(int day, int count) => _hintsRevealed[day] = count;

    public static GameProgress From(IEnumerable<int> completedDays, IReadOnlyDictionary<int, int>? hints = null)
    {
        var progress = new GameProgress();
        foreach (var day in completedDays)
        {
            progress.MarkCompleted(day);
        }

        if (hints is not null)
        {
            foreach (var (day, count) in hints)
            {
                progress.SetHintsRevealed(day, count);
            }
        }

        return progress;
    }
}
