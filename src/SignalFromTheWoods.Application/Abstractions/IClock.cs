namespace SignalFromTheWoods.Application.Abstractions;

public interface IClock
{
    DateTime Today { get; }
}
