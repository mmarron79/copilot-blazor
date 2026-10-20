namespace EventEase.Services;

public sealed class UserSessionTracker
{
    private readonly HashSet<int> registeredEventIds = [];

    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;

    public bool HasRegistered(int eventId) => registeredEventIds.Contains(eventId);

    public void UpdateProfile(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public bool TryRecordRegistration(int eventId)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(eventId);
        return registeredEventIds.Add(eventId);
    }
}
