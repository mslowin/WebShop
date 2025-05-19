using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Manufacturer"/> entities.
/// </summary>
public interface IManufacturerRepository
{
    /// <summary>
    /// Adds a new manufacturer to the repository.
    /// </summary>
    /// <param name="manufacturer">The manufacturer to add.</param>
    /// <returns>The identifier of the newly added manufacturer.</returns>
    int Add(Manufacturer manufacturer);

    /// <summary>
    /// Retrieves the manufacturer with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the manufacturer to retrieve.</param>
    /// <returns>The <see cref="Manufacturer"/> if found; otherwise, <c>null</c>.</returns>
    Manufacturer? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of manufacturers.
    /// </summary>
    /// <returns>An <see cref="IQueryable{Manufacturer}"/> representing all manufacturers.</returns>
    IQueryable<Manufacturer> Browse();

    /// <summary>
    /// Updates the specified manufacturer in the repository.
    /// </summary>
    /// <param name="manufacturer">The manufacturer to update.</param>
    void Update(Manufacturer manufacturer);

    /// <summary>
    /// Deletes the manufacturer with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the manufacturer to delete.</param>
    void Delete(int id);
}
