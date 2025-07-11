using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Customer"/> entities in the database.
/// </summary>
public class CustomerRepository : ICustomerRepository
{
    private EFContext _context { get; }

    public CustomerRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
        return customer.Id;
    }

    /// <inheritdoc/>
    public Customer? Get(int id)
    {
        return _context.Customers.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<Customer> Browse()
    {
        return _context.Customers.Where(c => !c.IsDeleted).AsQueryable();
    }

    /// <inheritdoc/>
    public void Update(Customer customer)
    {
        _context.Customers.Update(customer);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var customer = _context.Customers.Find(id);
        if (customer != null)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
