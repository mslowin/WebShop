using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Cart"/> entities.
/// </summary>
public interface ICartRepository
{
    /// <summary>
    /// Adds a new cart to the repository.
    /// </summary>
    int Add(Cart cart);

    /// <summary>
    /// Retrieves the cart with the specified identifier.
    /// </summary>
    Cart? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of carts.
    /// </summary>
    IQueryable<Cart> Browse();

    /// <summary>
    /// Updates the specified cart in the repository.
    /// </summary>
    void Update(Cart cart);

    /// <summary>
    /// Deletes the cart with the specified identifier.
    /// </summary>
    void Delete(int id);
}
