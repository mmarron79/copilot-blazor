namespace EventEase.Models;

public static class EventCatalog
{
    public static IReadOnlyList<EventInfo> Events { get; } =
    [
        new(1, "Autumn Makers Market", new DateTime(2026, 11, 14, 10, 0, 0), "The Foundry, Brooklyn, NY",
            "Meet local makers, browse handmade goods, and enjoy a relaxed day of shopping and community."),
        new(2, "An Evening of Live Jazz", new DateTime(2026, 11, 21, 19, 30, 0), "Blue Note Lounge, New York, NY",
            "Settle in for an intimate evening of live jazz, great company, and a welcoming neighborhood atmosphere."),
        new(3, "Community Garden Workshop", new DateTime(2026, 12, 5, 9, 0, 0), "Riverside Gardens, Queens, NY",
            "Learn seasonal gardening basics from local volunteers and help prepare the community garden for winter.")
    ];

    public static EventInfo? Find(int id) => Events.FirstOrDefault(eventItem => eventItem.Id == id);
}
