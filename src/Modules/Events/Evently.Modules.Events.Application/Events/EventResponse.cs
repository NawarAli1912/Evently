namespace Evently.Modules.Events.Application.Events;
public sealed record EventResponse(
    Guid Id,
    string Title,
    string Descriptions,
    string Location,
    DateTime StartAtUtc,
    DateTime? EndsAtUtc);
