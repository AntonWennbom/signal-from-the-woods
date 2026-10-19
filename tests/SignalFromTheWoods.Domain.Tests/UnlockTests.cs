using SignalFromTheWoods.Application.Abstractions;
using SignalFromTheWoods.Application.Services;

namespace SignalFromTheWoods.Domain.Tests;

public class UnlockTests
{
    private sealed class FakeClock(DateTime today) : IClock
    {
        public DateTime Today { get; } = today;
    }

    [Theory]
    [InlineData(2025, 11, 30, 0)]
    [InlineData(2025, 1, 15, 0)]
    [InlineData(2025, 12, 1, 1)]
    [InlineData(2025, 12, 13, 13)]
    [InlineData(2025, 12, 24, 24)]
    [InlineData(2025, 12, 28, 24)]
    public void MaxUnlockedDay_FollowsDate(int year, int month, int day, int expected)
    {
        var service = new UnlockService(new FakeClock(new DateTime(year, month, day)));

        Assert.Equal(expected, service.MaxUnlockedDay);
        Assert.Equal(expected > 0, service.HasCalendarOpened);
    }

    [Fact]
    public void IsUnlocked_RespectsMaxDay()
    {
        var service = new UnlockService(new FakeClock(new DateTime(2025, 12, 5)));

        Assert.True(service.IsUnlocked(5));
        Assert.False(service.IsUnlocked(6));
        Assert.False(service.IsUnlocked(0));
        Assert.False(service.IsUnlocked(25));
    }

    [Fact]
    public void DemoMode_UnlocksEverything()
    {
        var service = new UnlockService(new FakeClock(new DateTime(2025, 10, 1))) { IsDemoMode = true };

        Assert.True(service.HasCalendarOpened);
        Assert.True(service.IsUnlocked(24));
    }
}
