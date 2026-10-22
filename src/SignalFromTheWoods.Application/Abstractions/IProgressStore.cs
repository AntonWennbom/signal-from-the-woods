namespace SignalFromTheWoods.Application.Abstractions;

using SignalFromTheWoods.Domain.Progress;

public interface IProgressStore
{
    Task<GameProgress> LoadAsync();

    Task SaveAsync(GameProgress progress);
}
