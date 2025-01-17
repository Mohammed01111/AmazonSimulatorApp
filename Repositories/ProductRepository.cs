using AmazonSimulatorApp.Data;

namespace AmazonSimulatorApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return _context.Products.FirstOrDefault(p => p.PID == id);
        }

        public Product GetByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);

        }

        public List<Product> GetPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _context.Products.Where(p => p.Price > minPrice && p.Price < maxPrice).ToList();
        }


        public int UpdateProduct(Product pr)
        {
            Product product = GetByID(pr.PID);
            if (product != null)
            {
                product.Name = pr.Name;
                product.Description = pr.Description;
                product.Price = pr.Price;

                _context.Products.Update(product);
                _context.SaveChanges(true);
                return 1;
            }

            return -1;

        }

        public int DeleteProduct(int id)
        {
            Product product = GetByID(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return 1;
            }

            return -1;
        }

    }
}
