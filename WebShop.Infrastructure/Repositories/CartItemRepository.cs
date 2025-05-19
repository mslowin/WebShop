using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="CartItem"/> entities in the database.
/// </summary>
public class CartItemRepository : ICartItemRepository
{
    private EFContext _context { get; }

    public CartItemRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(CartItem cartItem)
    {
        _context.CartItems.Add(cartItem);
        _context.SaveChanges();
        return cartItem.Id;
    }

    /// <inheritdoc/>
    public CartItem? Get(int id)
    {
        return _context.CartItems.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<CartItem> Browse()
    {
        return _context.CartItems.AsQueryable();
    }

    /// <inheritdoc/>
    public void Update(CartItem cartItem)
    {
        _context.CartItems.Update(cartItem);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var cartItem = _context.CartItems.Find(id);
        if (cartItem != null)
        {
            _context.CartItems.Remove(cartItem);
            _context.SaveChanges();
        }
    }
}
