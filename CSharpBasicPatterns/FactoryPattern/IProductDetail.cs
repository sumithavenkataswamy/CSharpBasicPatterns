namespace CSharpBasicPatterns.FactoryPattern
{
    public interface IProductDetail
    {
        void DisplayProductDetails();
    }

    public class PhysicalProduct : IProductDetail
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("This is a physical product (e.g., a book, furniture).");
        }
    }

    public class DigitalProduct : IProductDetail
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("This is a digital product (e.g., an e-book, software).");
        }
    }

    public class ServiceProduct : IProductDetail
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("This is a service product (e.g., consulting, subscriptions).");
        }
    }
}
