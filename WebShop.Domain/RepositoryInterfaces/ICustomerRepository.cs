using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Customer"/> entities.
/// </summary>
public interface ICustomerRepository
{
    /// <summary>
    /// Adds a new customer to the repository.
    /// </summary>
    public int Add(Customer customer);

    /// <summary>
    /// Retrieves the customer with the specified identifier.
    /// </summary>
    public Customer? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of customers.
    /// </summary>
    public IQueryable<Customer> Browse();

    /// <summary>
    /// Updates the specified customer in the repository.
    /// </summary>
    public void Update(Customer customer);

    /// <summary>
    /// Deletes the customer with the specified identifier.
    /// </summary>
    public void Delete(int id);
}
