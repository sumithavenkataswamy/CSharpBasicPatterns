public sealed class Configuration
{
    public string ProductName { get; set; }
    public string ProductVersion { get; set; }
}

namespace CSharpBasicPatterns.SingletonPattern
{
    public sealed class ProductConfiguration
    {

        private List<Configuration> _configurations = new();
        private static ProductConfiguration _instance = null;
        private static readonly object _instanceLock = new object();

        private ProductConfiguration() { }        
        
        public static ProductConfiguration GetProductConfigurationInstance()
        {
            if (_instance == null)
            {
                Console.WriteLine("instance is null here");

                // it will allow only one thread to enter in the critical section
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        Console.WriteLine("ProductConfiguration instace created");
                        _instance = new ProductConfiguration();
                    }
                }
            }

            return _instance;
        }

        public List<Configuration> getProductConfigurations()
        {
            Console.WriteLine("Product configuration get method called");
            return _configurations;
        }

        public void SetProductConfiguration(Configuration configuration)
        {
            _configurations.Add(configuration);
            Console.WriteLine("Production configuration set method called");
        }
    }
}
