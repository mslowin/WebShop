using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="PaymentMethod"/> entities.
/// </summary>
public interface IPaymentMethodRepository
{
    /// <summary>
    /// Adds a new payment method to the repository.
    /// </summary>
    public int Add(PaymentMethod paymentMethod);

    /// <summary>
    /// Retrieves the payment method with the specified identifier.
    /// </summary>
    public PaymentMethod? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of payment methods.
    /// </summary>
    public IQueryable<PaymentMethod> Browse();

    /// <summary>
    /// Updates the specified payment method in the repository.
    /// </summary>
    public void Update(PaymentMethod paymentMethod);

    /// <summary>
    /// Deletes the payment method with the specified identifier.
    /// </summary>
    public void Delete(int id);
}
