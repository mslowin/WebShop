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
    public int Add(ShippingMethod shippingMethod);

    /// <summary>
    /// Retrieves the shipping method with the specified identifier.
    /// </summary>
    public ShippingMethod? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of shipping methods.
    /// </summary>
    public IQueryable<ShippingMethod> Browse();

    /// <summary>
    /// Updates the specified shipping method in the repository.
    /// </summary>
    public void Update(ShippingMethod shippingMethod);

    /// <summary>
    /// Deletes the shipping method with the specified identifier.
    /// </summary>
    public void Delete(int id);
}
