using WebShop.Domain.Models;

namespace WebShop.Domain.RepositoryInterfaces;

/// <summary>
/// Defines repository operations for managing <see cref="ProductImage"/> entities.
/// </summary>
public interface IProductImageRepository
{
    /// <summary>
    /// Adds a new product image to the repository.
    /// </summary>
    /// <param name="image">The product image to add.</param>
    /// <returns>The identifier of the newly added product image.</returns>
    int Add(ProductImage image);

    /// <summary>
    /// Retrieves a queryable collection of product images for a given product.
    /// </summary>
    /// <param name="productId">The product identifier to filter by.</param>
    /// <returns>An <see cref="IQueryable{ProductImage}"/> representing the product images.</returns>
    IQueryable<ProductImage> Browse(int productId);

    /// <summary>
    /// Deletes the product image with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the product image to delete.</param>
    void Delete(int id);

    /// <summary>
    /// Retrieves the product image with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier of the product image to retrieve.</param>
    /// <returns>The <see cref="ProductImage"/> if found; otherwise, <c>null</c>.</returns>
    ProductImage? Get(int id);

    /// <summary>
    /// Updates the specified product image in the repository.
    /// </summary>
    /// <param name="image">The product image to update.</param>
    void Update(ProductImage image);
}
