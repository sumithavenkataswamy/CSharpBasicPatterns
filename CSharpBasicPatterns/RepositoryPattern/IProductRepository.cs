using CSharpBasicPatterns.Common;

namespace CSharpBasicPatterns.RepositoryPattern
{
    public interface IProductRepository
    {
        Product? GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
    }
}
