namespace EventEase.Services;

public sealed class AttendanceTracker
{
    private readonly object sync = new();
    private readonly Dictionary<int, int> registrationCounts = [];

    public void RecordRegistration(int eventId)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(eventId);

        lock (sync)
        {
            registrationCounts[eventId] = registrationCounts.GetValueOrDefault(eventId) + 1;
        }
    }

    public int GetRegistrationCount(int eventId)
    {
        lock (sync)
        {
            return registrationCounts.GetValueOrDefault(eventId);
        }
    }
}
