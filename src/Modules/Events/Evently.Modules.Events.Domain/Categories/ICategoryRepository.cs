namespace Evently.Modules.Events.Domain.Categories;
public interface ICategoryRepository
{
    void Add(Category category);

    Task<Category?> GetAsync(Guid id, CancellationToken cancellationToken = default);
}
