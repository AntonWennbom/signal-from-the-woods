using SignalFromTheWoods.Domain.Calendar;
using SignalFromTheWoods.Domain.Progress;

namespace SignalFromTheWoods.Domain.Tests;

public class DayAccessPolicyTests
{
    [Fact]
    public void NewPlayerOnDay10_StartsAtDay1()
    {
        var progress = new GameProgress();

        Assert.Equal(DayStatus.Playable, DayAccessPolicy.GetStatus(1, progress, maxDateDay: 10));
        Assert.Equal(DayStatus.LockedByOrder, DayAccessPolicy.GetStatus(2, progress, maxDateDay: 10));
        Assert.Equal(DayStatus.LockedByOrder, DayAccessPolicy.GetStatus(10, progress, maxDateDay: 10));
    }

    [Fact]
    public void CompletingDays_MovesPlayableDayForward()
    {
        var progress = GameProgress.From([1, 2, 3]);

        Assert.Equal(DayStatus.Completed, DayAccessPolicy.GetStatus(3, progress, 10));
        Assert.Equal(DayStatus.Playable, DayAccessPolicy.GetStatus(4, progress, 10));
        Assert.Equal(DayStatus.LockedByOrder, DayAccessPolicy.GetStatus(5, progress, 10));
    }

    [Fact]
    public void CaughtUpWithDate_NextDayWaitsForDate()
    {
        var progress = GameProgress.From(Enumerable.Range(1, 10));

        Assert.Equal(DayStatus.Completed, DayAccessPolicy.GetStatus(10, progress, 10));
        Assert.Equal(DayStatus.WaitingForDate, DayAccessPolicy.GetStatus(11, progress, 10));
        Assert.Equal(DayStatus.LockedByOrder, DayAccessPolicy.GetStatus(12, progress, 10));
    }

    [Fact]
    public void BeforeCalendarOpens_Day1WaitsForDate()
    {
        Assert.Equal(DayStatus.WaitingForDate, DayAccessPolicy.GetStatus(1, new GameProgress(), maxDateDay: 0));
    }

    [Fact]
    public void CanPlay_AllowsReplayOfCompletedDays()
    {
        var progress = GameProgress.From([1, 2]);

        Assert.True(DayAccessPolicy.CanPlay(1, progress, 5));
        Assert.True(DayAccessPolicy.CanPlay(3, progress, 5));
        Assert.False(DayAccessPolicy.CanPlay(4, progress, 5));
    }

    [Fact]
    public void NextDay_SkipsCompletedAndHandlesGaps()
    {
        Assert.Equal(1, new GameProgress().NextDay);
        Assert.Equal(3, GameProgress.From([1, 2, 4]).NextDay);
        Assert.Equal(25, GameProgress.From(Enumerable.Range(1, 24)).NextDay);
    }

    [Fact]
    public void Hints_AreTrackedPerDay()
    {
        var progress = new GameProgress();
        progress.SetHintsRevealed(4, 2);

        Assert.Equal(2, progress.GetHintsRevealed(4));
        Assert.Equal(0, progress.GetHintsRevealed(5));
    }
}
