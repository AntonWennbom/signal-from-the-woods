using System.Diagnostics.CodeAnalysis;
using SignalFromTheWoods.Domain.Calendar;

namespace SignalFromTheWoods.Web.Components.Puzzles;

/// <summary>
/// Maps a puzzle type key from <see cref="DayDefinition.PuzzleType"/> to its Razor component.
/// </summary>
public static class PuzzleRegistry
{
    private static readonly Dictionary<string, Type> Types = new()
    {
        [DayCatalog.FrequencyPuzzle] = typeof(FrequencyPuzzle)
    };

    public static bool TryGetType(string key, [NotNullWhen(true)] out Type? type) =>
        Types.TryGetValue(key, out type);
}
