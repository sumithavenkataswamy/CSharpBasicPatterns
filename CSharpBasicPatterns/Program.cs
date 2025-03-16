using CSharpBasicPatterns.RepositoryPattern;
using CSharpBasicPatterns.SingletonPattern;

#region Singleton Pattern Caller 
//var instance = ProductConfiguration.GetProductConfigurationInstance();

//instance.SetProductConfiguration(new Configuration()
//{
//    ProductName = "Laptop",
//    ProductVersion = "1.0.0",
//});

//PrintProdConfiguration();

//void PrintProdConfiguration()
//{
//    foreach (var item in instance.getProductConfigurations())
//    {
//        Console.WriteLine($"ProductName: {item.ProductName} ProductVersion: {item.ProductVersion}");
//    }
//}

#region Multithreads

//static void CreateInstance() => ProductConfiguration.GetProductConfigurationInstance();
//// Create an array of threads
//Thread[] threads = new Thread[5];

//// Initialize and start multiple threads
//for (int i = 0; i < threads.Length; i++)
//{
//    threads[i] = new Thread(CreateInstance);
//    threads[i].Start();
//}

//// Wait for all threads to complete
//foreach (Thread thread in threads)
//{
//    thread.Join();
//}

//Console.WriteLine("All threads have completed execution.");
#endregion
#endregion

#region Repository Pattern Caller
IProductRepository productRepository = new ProductRepository();
foreach(var product in productRepository.GetAllProducts())
{
    Console.WriteLine(product.Name);
}
#endregion