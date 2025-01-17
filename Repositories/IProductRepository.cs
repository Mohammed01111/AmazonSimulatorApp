using AmazonSimulatorApp.Data;

namespace AmazonSimulatorApp.Data.Repositories
{
    public interface IProductRepository
    {
        int DeleteProduct(int id);
        List<Product> GetAllProducts();
        Product GetByID(int id);
        Product GetByName(string name);
        List<Product> GetPriceRange(decimal minPrice, decimal maxPrice);
        int UpdateProduct(Product pr);
    }
}