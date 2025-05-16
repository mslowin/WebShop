using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="Order"/> entities in the database.
/// </summary>
public class OrderRepository : IOrderRepository
{
    private EFContext _context { get; }

    public OrderRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
        return order.Id;
    }

    /// <inheritdoc/>
    public IQueryable<Order> Browse()
    {
        return _context.Orders.AsQueryable();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var order = _context.Orders.Find(id);
        if (order != null)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }

    /// <inheritdoc/>
    public Order? Get(int id)
    {
        return _context.Orders.Find(id);
    }

    /// <inheritdoc/>
    public void Update(Order order)
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
    }
}
