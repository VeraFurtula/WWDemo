using WWDemo.Models;

namespace WWDemo.Data.Products
{
    public interface IProductRepository
    {
        Task<List<Product?>> GetAllProducts();

        Task<Product?> GetProductById(Guid productId);

        Task<Product?> GetProductBySerialNumber(string SerialNumber);

        Task<Product?> AddProduct(Product product);

        Task<Product?> UpdateProduct(Product product);

    }
}
