using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="CartItem"/> entities.
/// </summary>
public interface ICartItemRepository
{
    /// <summary>
    /// Adds a new cart item to the repository.
    /// </summary>
    int Add(CartItem cartItem);

    /// <summary>
    /// Retrieves the cart item with the specified identifier.
    /// </summary>
    CartItem? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of cart items.
    /// </summary>
    IQueryable<CartItem> Browse();

    /// <summary>
    /// Updates the specified cart item in the repository.
    /// </summary>
    void Update(CartItem cartItem);

    /// <summary>
    /// Deletes the cart item with the specified identifier.
    /// </summary>
    void Delete(int id);
}
