using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="ShippingMethod"/> entities in the database.
/// </summary>
public class ShippingMethodRepository : IShippingMethodRepository
{
    private EFContext _context { get; }

    public ShippingMethodRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(ShippingMethod shippingMethod)
    {
        _context.ShippingMethods.Add(shippingMethod);
        _context.SaveChanges();
        return shippingMethod.Id;
    }

    /// <inheritdoc/>
    public IQueryable<ShippingMethod> Browse()
    {
        return _context.ShippingMethods.AsQueryable();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var shippingMethod = _context.ShippingMethods.Find(id);
        if (shippingMethod != null)
        {
            _context.ShippingMethods.Remove(shippingMethod);
            _context.SaveChanges();
        }
    }

    /// <inheritdoc/>
    public ShippingMethod? Get(int id)
    {
        return _context.ShippingMethods.Find(id);
    }

    /// <inheritdoc/>
    public void Update(ShippingMethod shippingMethod)
    {
        _context.ShippingMethods.Update(shippingMethod);
        _context.SaveChanges();
    }
}
