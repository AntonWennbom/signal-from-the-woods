using SignalFromTheWoods.Application.Abstractions;

namespace SignalFromTheWoods.Web.Infrastructure;

public class SystemClock : IClock
{
    public DateTime Today => DateTime.Now;
}
