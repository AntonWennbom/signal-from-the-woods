namespace SignalFromTheWoods.Domain.Calendar;

/// <summary>
/// Static content for one day. All texts are resource keys so they can be localized.
/// </summary>
public sealed record DayDefinition(
    int Number,
    string TitleKey,
    string MemoryKey,
    string SceneImage,
    string PuzzleType,
    IReadOnlyList<Hotspot> Hotspots,
    IReadOnlyList<string> HintKeys,
    string? PuzzleImage = null,
    string? CompletionKey = null);
