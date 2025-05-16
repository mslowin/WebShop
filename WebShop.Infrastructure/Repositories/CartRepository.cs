using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Cart"/> entities in the database.
/// </summary>
public class CartRepository : ICartRepository
{
    private EFContext _context { get; }

    public CartRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Cart cart)
    {
        _context.Carts.Add(cart);
        _context.SaveChanges();
        return cart.Id;
    }

    /// <inheritdoc/>
    public IQueryable<Cart> Browse()
    {
        return _context.Carts.AsQueryable();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var cart = _context.Carts.Find(id);
        if (cart != null)
        {
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }
    }

    /// <inheritdoc/>
    public Cart? Get(int id)
    {
        return _context.Carts.Find(id);
    }

    /// <inheritdoc/>
    public void Update(Cart cart)
    {
        _context.Carts.Update(cart);
        _context.SaveChanges();
    }
}
