namespace SignalFromTheWoods.Domain.Calendar;

/// <summary>
/// All day definitions. Kept in C# for now; can be moved to JSON later.
/// Hotspot positions are percentages of the scene image.
/// </summary>
public static class DayCatalog
{
    public const string FrequencyPuzzle = "frequency";

    private static readonly IReadOnlyList<DayDefinition> Days =
    [
        new DayDefinition(
            Number: 1,
            TitleKey: "Day1_Title",
            MemoryKey: "Day1_Memory",
            SceneImage: "images/day-01/day-01.webp",
            PuzzleType: FrequencyPuzzle,
            Hotspots:
            [
                new Hotspot("radio", HotspotKind.StartPuzzle, 51, 30, 24, 30, "Day1_Radio_Label"),
                new Hotspot("coffee", HotspotKind.Info, 39, 45, 8, 12, "Day1_Coffee_Label", "Day1_Coffee_Text"),
                new Hotspot("jacket", HotspotKind.Info, 7, 38, 30, 60, "Day1_Jacket_Label", "Day1_Jacket_Text")
            ],
            HintKeys: ["Day1_Hint1", "Day1_Hint2", "Day1_Hint3"],
                        PuzzleImage: "images/day-01/day-01-game.webp",
                        CompletionKey: "Day1_Completion")
    ];

    public static IReadOnlyList<DayDefinition> All => Days;

    public static DayDefinition? Get(int number) => Days.FirstOrDefault(day => day.Number == number);
}
