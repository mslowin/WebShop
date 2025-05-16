using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="ShippingMethod"/> entities.
/// </summary>
public interface IShippingMethodRepository
{
    /// <summary>
    /// Adds a new shipping method to the repository.
    /// </summary>
    int Add(ShippingMethod shippingMethod);

    /// <summary>
    /// Retrieves a queryable collection of shipping methods.
    /// </summary>
    IQueryable<ShippingMethod> Browse();

    /// <summary>
    /// Deletes the shipping method with the specified identifier.
    /// </summary>
    void Delete(int id);

    /// <summary>
    /// Retrieves the shipping method with the specified identifier.
    /// </summary>
    ShippingMethod? Get(int id);

    /// <summary>
    /// Updates the specified shipping method in the repository.
    /// </summary>
    void Update(ShippingMethod shippingMethod);
}
