using ProductCatalog.API.Models;
namespace ProductCatalog.API.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>()
        {
             new Product { Id = 1, Name = "Laptop", Price = 999.99m },
             new Product {Id=2, Name="Keyboard",Price = 123.99m}
        };      
        public List<Product> GetAll()
        {
            return _products;
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;           
            _products.Add(product);
            return product;
        }

    }
}
