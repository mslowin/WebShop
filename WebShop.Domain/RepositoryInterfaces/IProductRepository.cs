using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="Product"/> entities.
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// Adds a new product to the repository.
    /// </summary>
    /// <param name="product">The product to add.</param>
    /// <returns>The identifier of the newly added product.</returns>
    int Add(Product product);

    /// <summary>
    /// Retrieves the product with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the product to retrieve.</param>
    /// <returns>The <see cref="Product"/> if found; otherwise, <c>null</c>.</returns>
    Product? Get(int id);

    /// <summary>
    /// Retrieves a queryable collection of products, optionally filtered by category and/or manufacturer.
    /// </summary>
    /// <param name="categoryId">The category identifier to filter by, or <c>null</c> to include all categories.</param>
    /// <param name="manufacturerId">The manufacturer identifier to filter by, or <c>null</c> to include all manufacturers.</param>
    /// <returns>An <see cref="IQueryable{Product}"/> representing the filtered products.</returns>
    IQueryable<Product> Browse(int? categoryId = null, int? manufacturerId = null);

    /// <summary>
    /// Updates the specified product in the repository.
    /// </summary>
    /// <param name="product">The product to update.</param>
    void Update(Product product);

    /// <summary>
    /// Deletes the product with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the product to delete.</param>
    void Delete(int id);
}
