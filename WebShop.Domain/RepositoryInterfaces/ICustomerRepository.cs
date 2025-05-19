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
    int Add(Customer customer);

    /// <summary>
    /// Retrieves the customer with the specified identifier.
    /// </summary>
    Customer? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of customers.
    /// </summary>
    IQueryable<Customer> Browse();

    /// <summary>
    /// Updates the specified customer in the repository.
    /// </summary>
    void Update(Customer customer);

    /// <summary>
    /// Deletes the customer with the specified identifier.
    /// </summary>
    void Delete(int id);
}
