using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="OrderItem"/> entities in the database.
/// </summary>
public class OrderItemRepository : IOrderItemRepository
{
    private EFContext _context { get; }

    public OrderItemRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(OrderItem orderItem)
    {
        _context.OrderItems.Add(orderItem);
        _context.SaveChanges();
        return orderItem.Id;
    }

    /// <inheritdoc/>
    public OrderItem? Get(int id)
    {
        return _context.OrderItems.Find(id);
    }

    /// <inheritdoc/>
    public IQueryable<OrderItem> Browse()
    {
        return _context.OrderItems.AsQueryable();
    }

    /// <inheritdoc/>
    public void Update(OrderItem orderItem)
    {
        _context.OrderItems.Update(orderItem);
        _context.SaveChanges();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var orderItem = _context.OrderItems.Find(id);
        if (orderItem != null)
        {
            _context.OrderItems.Remove(orderItem);
            _context.SaveChanges();
        }
    }
}
