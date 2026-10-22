using SignalFromTheWoods.Domain.Progress;

namespace SignalFromTheWoods.Domain.Tests;

public class GameProgressResetTests
{
    [Fact]
    public void JumpTo_CompletesEarlierDaysOnly()
    {
        var progress = new GameProgress();

        progress.JumpTo(5);

        Assert.Equal([1, 2, 3, 4], progress.CompletedDays.Order());
        Assert.Equal(5, progress.NextDay);
    }

    [Fact]
    public void JumpTo_ClearsLaterDaysAndTheirHints()
    {
        var progress = GameProgress.From([1, 2, 3, 4, 5, 6]);
        progress.SetHintsRevealed(2, 1);
        progress.SetHintsRevealed(5, 3);

        progress.JumpTo(4);

        Assert.False(progress.IsCompleted(4));
        Assert.False(progress.IsCompleted(6));
        Assert.Equal(1, progress.GetHintsRevealed(2));
        Assert.Equal(0, progress.GetHintsRevealed(5));
    }

    [Fact]
    public void Reset_ClearsEverything()
    {
        var progress = GameProgress.From([1, 2, 3]);
        progress.SetHintsRevealed(1, 2);

        progress.Reset();

        Assert.Equal(0, progress.CompletedCount);
        Assert.Equal(0, progress.GetHintsRevealed(1));
        Assert.Equal(1, progress.NextDay);
    }
}
