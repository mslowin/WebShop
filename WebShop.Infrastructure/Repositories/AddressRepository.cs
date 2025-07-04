using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Address"/> entities in the database.
/// </summary>
public class AddressRepository : IAddressRepository
{
    private EFContext _context { get; }

    public AddressRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Address address)
    {
        _context.Addresses.Add(address);
        _context.SaveChanges();
        return address.Id;
    }

    /// <inheritdoc/>
    public Address? Get(int id)
    {
        return _context.Addresses.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<Address> Browse()
    {
        return _context.Addresses.AsQueryable();
    }

    /// <inheritdoc/>
    public void Update(Address address)
    {
        _context.Addresses.Update(address);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var address = _context.Addresses.Find(id);
        if (address != null)
        {
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }
    }
}
