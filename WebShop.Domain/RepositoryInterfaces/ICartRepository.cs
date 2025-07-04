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
    public int Add(Cart cart);

    /// <summary>
    /// Retrieves the cart with the specified identifier.
    /// </summary>
    public Cart? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of carts.
    /// </summary>
    public IQueryable<Cart> Browse();

    /// <summary>
    /// Updates the specified cart in the repository.
    /// </summary>
    public void Update(Cart cart);

    /// <summary>
    /// Deletes the cart with the specified identifier.
    /// </summary>
    public void Delete(int id);
}
