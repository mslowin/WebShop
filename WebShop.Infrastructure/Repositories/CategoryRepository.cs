using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Category"/> entities in the database.
/// </summary>
public class CategoryRepository : ICategoryRepository
{
    private EFContext _context { get; }

    public CategoryRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return category.Id;
    }

    /// <inheritdoc/>
    public IQueryable<Category> Browse()
    {
        return _context.Categories.AsQueryable();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var category = _context.Categories.Find(id);
        if (category != null)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }

    /// <inheritdoc/>
    public Category? Get(int id)
    {
        return _context.Categories.Find(id);
    }

    /// <inheritdoc/>
    public void Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
    }
}
