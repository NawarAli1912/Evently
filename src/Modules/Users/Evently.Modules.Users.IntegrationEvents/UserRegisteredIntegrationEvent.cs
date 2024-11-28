using Evently.Common.Application.EventBus;

namespace Evently.Modules.Users.IntegrationEvents;

public class UserRegisteredIntegrationEvent : IntegrationEvent
{
    public UserRegisteredIntegrationEvent(
        Guid id,
        DateTime occuredOnUtc,
        Guid userId,
        string email,
        string firstName,
        string lastName) : base(id, occuredOnUtc)
    {
        UserId = userId;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
    }

    public Guid UserId { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

}
