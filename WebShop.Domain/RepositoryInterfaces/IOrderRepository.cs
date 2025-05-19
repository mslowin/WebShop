using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Order"/> entities.
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// Adds a new order to the repository.
    /// </summary>
    int Add(Order order);

    /// <summary>
    /// Retrieves the order with the specified identifier.
    /// </summary>
    Order? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of orders.
    /// </summary>
    IQueryable<Order> Browse();

    /// <summary>
    /// Updates the specified order in the repository.
    /// </summary>
    void Update(Order order);

    /// <summary>
    /// Deletes the order with the specified identifier.
    /// </summary>
    void Delete(int id);
}
