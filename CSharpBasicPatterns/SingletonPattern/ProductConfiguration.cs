public sealed class Configuration
{
    public string ProductName { get; set; }
    public string ProductVersion { get; set; }
}

namespace CSharpBasicPatterns.SingletonPattern
{
    // eagar loading
    // it will create instace when application starts
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

    // lazy loading
    // it will create instance when first time accessed, in cases if you didn't access, it will not create it

    public sealed class ProductConfigurationLazy
    {
        private List<Configuration> _configurations = new();

        // private constructor
        private ProductConfigurationLazy() 
        {
            Console.WriteLine("ProductConfiguration instance created");
        }

        //  lazy way of creating instance
        private static readonly Lazy<ProductConfigurationLazy> _instance = 
            new Lazy<ProductConfigurationLazy>(() => new ProductConfigurationLazy());

        // multiple thread 
        //private static readonly Lazy<ProductConfigurationLazy> _instance =
        //   new Lazy<ProductConfigurationLazy>(() => new ProductConfigurationLazy(), true);

        // when we call this property, it will check instance already created or not, if not created it will create it. or it will return the existing instance.
        // thread safety also provided it
        public static ProductConfigurationLazy GetInstance() => _instance.Value;

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
