namespace SignalFromTheWoods.Application.Abstractions;

public interface IProgressStore
{
    Task<IReadOnlySet<int>> GetCompletedDaysAsync();

    Task MarkDayCompletedAsync(int day);
}
