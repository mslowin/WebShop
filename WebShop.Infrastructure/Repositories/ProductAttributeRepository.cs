using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="ProductAttribute"/> entities in the database.
/// </summary>
public class ProductAttributeRepository : IProductAttributeRepository
{
    private EFContext _context { get; }

    public ProductAttributeRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(ProductAttribute attribute)
    {
        _context.ProductAttributes.Add(attribute);
        _context.SaveChanges();
        return attribute.Id;
    }

    /// <inheritdoc/>
    public ProductAttribute? Get(int id)
    {
        return _context.ProductAttributes.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<ProductAttribute> Browse(int productId)
    {
        return _context.ProductAttributes.Where(a => a.ProductId == productId);
    }

    /// <inheritdoc/>
    public void Update(ProductAttribute attribute)
    {
        _context.ProductAttributes.Update(attribute);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var attribute = _context.ProductAttributes.Find(id);
        if (attribute != null)
        {
            _context.ProductAttributes.Remove(attribute);
            _context.SaveChanges();
        }
    }
}
