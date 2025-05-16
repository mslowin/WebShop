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
    int Add(PaymentMethod paymentMethod);

    /// <summary>
    /// Retrieves a queryable collection of payment methods.
    /// </summary>
    IQueryable<PaymentMethod> Browse();

    /// <summary>
    /// Deletes the payment method with the specified identifier.
    /// </summary>
    void Delete(int id);

    /// <summary>
    /// Retrieves the payment method with the specified identifier.
    /// </summary>
    PaymentMethod? Get(int id);

    /// <summary>
    /// Updates the specified payment method in the repository.
    /// </summary>
    void Update(PaymentMethod paymentMethod);
}
