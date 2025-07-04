using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Address"/> entities.
/// </summary>
public interface IAddressRepository
{
    /// <summary>
    /// Adds a new address to the repository.
    /// </summary>
    public int Add(Address address);

    /// <summary>
    /// Retrieves the address with the specified identifier.
    /// </summary>
    public Address? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of addresses.
    /// </summary>
    public IQueryable<Address> Browse();

    /// <summary>
    /// Updates the specified address in the repository.
    /// </summary>
    public void Update(Address address);

    /// <summary>
    /// Deletes the address with the specified identifier.
    /// </summary>
    public void Delete(int id);
}
