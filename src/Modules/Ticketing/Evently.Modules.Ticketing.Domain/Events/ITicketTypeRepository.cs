namespace Evently.Modules.Ticketing.Domain.Events;

public interface ITicketTypeRepository
{
    Task<TicketType?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    Task<List<TicketType>> GetWithLockAsync(
        IEnumerable<Guid> ids,
        CancellationToken cancellationToken = default);

    void InsertRange(IEnumerable<TicketType> ticketTypes);
}
