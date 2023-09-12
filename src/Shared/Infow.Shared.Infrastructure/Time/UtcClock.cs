using Infow.Shared.Abstractions.Time;

namespace Infow.Shared.Infrastructure.Time;

internal sealed class UtcClock : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}