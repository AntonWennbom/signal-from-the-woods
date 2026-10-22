using System.Text.Json;
using Microsoft.JSInterop;
using SignalFromTheWoods.Application.Abstractions;
using SignalFromTheWoods.Domain.Progress;

namespace SignalFromTheWoods.Web.Infrastructure;

public class LocalStorageProgressStore(IJSRuntime js) : IProgressStore
{
    private const string StorageKey = "sftw.progress";

    public async Task<GameProgress> LoadAsync()
    {
        var json = await js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
        if (string.IsNullOrWhiteSpace(json))
        {
            return new GameProgress();
        }

        try
        {
            var data = JsonSerializer.Deserialize<ProgressData>(json);
            return data is null
                ? new GameProgress()
                : GameProgress.From(data.Completed ?? [], data.Hints);
        }
        catch (JsonException)
        {
            return new GameProgress();
        }
    }

    public async Task SaveAsync(GameProgress progress)
    {
        var data = new ProgressData(
            progress.CompletedDays.Order().ToList(),
            progress.HintsRevealed.ToDictionary(pair => pair.Key, pair => pair.Value));

        await js.InvokeVoidAsync("localStorage.setItem", StorageKey, JsonSerializer.Serialize(data));
    }

    private sealed record ProgressData(List<int>? Completed, Dictionary<int, int>? Hints);
}
