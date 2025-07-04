using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="ProductAttribute"/> entities.
/// </summary>
public interface IProductAttributeRepository
{
    /// <summary>
    /// Adds a new product attribute to the repository.
    /// </summary>
    /// <param name="attribute">The product attribute to add.</param>
    /// <returns>The identifier of the newly added product attribute.</returns>
    public int Add(ProductAttribute attribute);

    /// <summary>
    /// Retrieves the product attribute with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the product attribute to retrieve.</param>
    /// <returns>The <see cref="ProductAttribute"/> if found; otherwise, <c>null</c>.</returns>
    public ProductAttribute? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of product attributes for a given product.
    /// </summary>
    /// <param name="productId">The product identifier to filter by.</param>
    /// <returns>An <see cref="IQueryable{ProductAttribute}"/> representing the product attributes.</returns>
    public IQueryable<ProductAttribute> Browse(int productId);

    /// <summary>
    /// Updates the specified product attribute in the repository.
    /// </summary>
    /// <param name="attribute">The product attribute to update.</param>
    public void Update(ProductAttribute attribute);

    /// <summary>
    /// Deletes the product attribute with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the product attribute to delete.</param>
    public void Delete(int id);
}
