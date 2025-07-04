using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Manufacturer"/> entities in the database.
/// </summary>
public class ManufacturerRepository : IManufacturerRepository
{
    private EFContext _context { get; }

    public ManufacturerRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Manufacturer manufacturer)
    {
        _context.Manufacturers.Add(manufacturer);
        _context.SaveChanges();
        return manufacturer.Id;
    }

    /// <inheritdoc/>
    public Manufacturer? Get(int id)
    {
        return _context.Manufacturers.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<Manufacturer> Browse()
    {
        return _context.Manufacturers.AsQueryable();
    }

    /// <inheritdoc/>
    public void Update(Manufacturer manufacturer)
    {
        _context.Manufacturers.Update(manufacturer);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var manufacturer = _context.Manufacturers.Find(id);
        if (manufacturer != null)
        {
            _context.Manufacturers.Remove(manufacturer);
            _context.SaveChanges();
        }
    }
}
