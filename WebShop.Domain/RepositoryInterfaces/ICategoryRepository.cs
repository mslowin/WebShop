using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Category"/> entities.
/// </summary>
public interface ICategoryRepository
{
    /// <summary>
    /// Adds a new category to the repository.
    /// </summary>
    /// <param name="category">The category to add.</param>
    /// <returns>The identifier of the newly added category.</returns>
    public int Add(Category category);

    /// <summary>
    /// Retrieves the category with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the category to retrieve.</param>
    /// <returns>The <see cref="Category"/> if found; otherwise, <c>null</c>.</returns>
    public Category? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of categories.
    /// </summary>
    /// <returns>An <see cref="IQueryable{Category}"/> representing all categories.</returns>
    public IQueryable<Category> Browse();

    /// <summary>
    /// Updates the specified category in the repository.
    /// </summary>
    /// <param name="category">The category to update.</param>
    public void Update(Category category);

    /// <summary>
    /// Deletes the category with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the category to delete.</param>
    public void Delete(int id);
}
