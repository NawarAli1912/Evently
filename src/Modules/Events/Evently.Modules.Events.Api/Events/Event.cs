namespace Evently.Modules.Events.Api.Events;

public sealed class Event
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Location { get; set; }

    public DateTime StartsAtUtc { get; set; }

    public DateTime? EndAtUtc { get; set; }

    public EventStatus Status { get; set; }
}
