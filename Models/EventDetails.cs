namespace EventEase.Models;

public sealed record EventInfo(int Id, string EventName, DateTime EventDate, string Location, string Description);
