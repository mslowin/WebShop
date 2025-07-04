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
    public int Add(Order order);

    /// <summary>
    /// Retrieves the order with the specified identifier.
    /// </summary>
    public Order? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of orders.
    /// </summary>
    public IQueryable<Order> Browse();

    /// <summary>
    /// Updates the specified order in the repository.
    /// </summary>
    public void Update(Order order);

    /// <summary>
    /// Deletes the order with the specified identifier.
    /// </summary>
    public void Delete(int id);
}
