namespace SignalFromTheWoods.Domain.Calendar;

/// <summary>
/// A clickable area on a day scene. Position and size are percentages (0-100) of the scene image.
/// </summary>
public sealed record Hotspot(
    string Id,
    HotspotKind Kind,
    double X,
    double Y,
    double Width,
    double Height,
    string LabelKey,
    string? TextKey = null);
