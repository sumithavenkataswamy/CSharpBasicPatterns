using CSharpBasicPatterns.Common;

namespace CSharpBasicPatterns.RepositoryPattern
{
    public class ProductRepository : IProductRepository
    {
        private readonly IEnumerable<Product> _products;
        public ProductRepository() 
        { 
            _products = new List<Product>()
            {
                new()
                {
                    Id = 1,
                    Description = "Laptop",
                    Name = "Laptop",
                    Title = "Laptop"
                },
                new()
                {
                    Id = 2,
                    Description = "Mouse",
                    Name = "Mouse",
                    Title = "Mouse"
                },
                new()
                {
                    Id = 3,
                    Description = "Keyboard",
                    Name = "Keyboard",
                    Title = "Keyboard"
                }
            };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(product => product.Id.Equals(id));
        }
    }
}
