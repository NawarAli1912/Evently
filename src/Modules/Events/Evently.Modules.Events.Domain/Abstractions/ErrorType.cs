namespace Evently.Modules.Events.Domain.Abstractions;
public enum ErrorType
{
    Failure,
    Unexpected,
    Validation,
    Problem,
    Conflict,
    NotFound,
    Unauthorized,
    Forbidden,
}
