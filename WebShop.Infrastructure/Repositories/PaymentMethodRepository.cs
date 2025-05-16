using WebShop.Domain.Models;
using WebShop.Domain.RepositoryInterfaces;

namespace WebShop.Infrastructure.Repositories;

/// <summary>
/// Repository for managing <see cref="PaymentMethod"/> entities in the database.
/// </summary>
public class PaymentMethodRepository : IPaymentMethodRepository
{
    private EFContext _context { get; }

    public PaymentMethodRepository(EFContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public int Add(PaymentMethod paymentMethod)
    {
        _context.PaymentMethods.Add(paymentMethod);
        _context.SaveChanges();
        return paymentMethod.Id;
    }

    /// <inheritdoc/>
    public IQueryable<PaymentMethod> Browse()
    {
        return _context.PaymentMethods.AsQueryable();
    }

    /// <inheritdoc/>
    public void Delete(int id)
    {
        var paymentMethod = _context.PaymentMethods.Find(id);
        if (paymentMethod != null)
        {
            _context.PaymentMethods.Remove(paymentMethod);
            _context.SaveChanges();
        }
    }

    /// <inheritdoc/>
    public PaymentMethod? Get(int id)
    {
        return _context.PaymentMethods.Find(id);
    }

    /// <inheritdoc/>
    public void Update(PaymentMethod paymentMethod)
    {
        _context.PaymentMethods.Update(paymentMethod);
        _context.SaveChanges();
    }
}
