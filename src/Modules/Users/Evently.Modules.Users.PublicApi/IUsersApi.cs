namespace Evently.Modules.Users.PublicApi;

public interface IUsersApi
{
    Task<UserResponse> GetAsync(Guid userId, CancellationToken cancellationToken = default);
}


public sealed record UserResponse(Guid Id, string Email, string FirstName, string LastName);
