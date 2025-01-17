using AmazonSimulatorApp.Data;
using AmazonSimulatorApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AmazonSimulatorApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetByID(int id)
        {
            return _repository.GetByID(id);
        }

        public Product GetByName(string name)
        {
            return _repository.GetByName(name);

        }

        public List<Product> GetPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _repository.GetPriceRange(minPrice, maxPrice);
        }

        public int UpdateProduct(Product pr)
        {
            return _repository.UpdateProduct(pr);
        }

        public int DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }
    }
}
