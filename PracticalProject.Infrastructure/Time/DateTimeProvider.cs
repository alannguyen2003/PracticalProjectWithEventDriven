using PracticalProject.SharedKernel;

namespace PracticalProject.Infrastructure.Time;

public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}