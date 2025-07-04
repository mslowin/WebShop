using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Product"/> entities in the database.
/// </summary>
public class ProductRepository : IProductRepository
{
    private EFContext _context { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRepository"/> class.
    /// </summary>
    /// <param name="context">The EF database context.</param>
    public ProductRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();

        return product.Id;
    }

    /// <inheritdoc/>
    public Product? Get(int id)
    {
        return _context.Products.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<Product> Browse(int? categoryId = null, int? manufacturerId = null)
    {
        var query = _context.Products.AsQueryable();
        if (categoryId.HasValue)
        {
            query = query.Where(p => p.CategoryId == categoryId.Value);
        }
        if (manufacturerId.HasValue)
        {
            query = query.Where(p => p.ManufacturerId == manufacturerId.Value);
        }

        return query;
    }

    /// <inheritdoc/>
    public void Update(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
