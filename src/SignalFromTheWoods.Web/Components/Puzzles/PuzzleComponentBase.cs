using Microsoft.AspNetCore.Components;

namespace SignalFromTheWoods.Web.Components.Puzzles;

/// <summary>
/// Base class for all puzzles. The puzzle host passes these parameters via DynamicComponent.
/// </summary>
public abstract class PuzzleComponentBase : ComponentBase
{
    [Parameter]
    public string? BackgroundImage { get; set; }

    [Parameter]
    public EventCallback OnCompleted { get; set; }
}
