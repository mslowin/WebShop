using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="OrderItem"/> entities.
/// </summary>
public interface IOrderItemRepository
{
    /// <summary>
    /// Adds a new order item to the repository.
    /// </summary>
    int Add(OrderItem orderItem);

    /// <summary>
    /// Retrieves the order item with the specified identifier.
    /// </summary>
    OrderItem? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of order items.
    /// </summary>
    IQueryable<OrderItem> Browse();

    /// <summary>
    /// Updates the specified order item in the repository.
    /// </summary>
    void Update(OrderItem orderItem);

    /// <summary>
    /// Deletes the order item with the specified identifier.
    /// </summary>
    void Delete(int id);
}
