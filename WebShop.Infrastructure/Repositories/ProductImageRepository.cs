using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="ProductImage"/> entities in the database.
/// </summary>
public class ProductImageRepository : IProductImageRepository
{
    private EFContext _context { get; }

    public ProductImageRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(ProductImage image)
    {
        _context.ProductImages.Add(image);
        _context.SaveChanges();
        return image.Id;
    }

    /// <inheritdoc/>
    public IQueryable<ProductImage> Browse(int productId)
    {
        return _context.ProductImages.Where(i => i.ProductId == productId);
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var image = _context.ProductImages.Find(id);
        if (image != null)
        {
            _context.ProductImages.Remove(image);
            _context.SaveChanges();
        }
    }

    /// <inheritdoc/>
    public ProductImage? Get(int id)
    {
        return _context.ProductImages.Find(id);
    }

    /// <inheritdoc/>
    public void Update(ProductImage image)
    {
        _context.ProductImages.Update(image);
        _context.SaveChanges();
    }
}
