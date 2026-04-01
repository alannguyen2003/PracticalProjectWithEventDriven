namespace PracticalProject.SharedKernel;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}