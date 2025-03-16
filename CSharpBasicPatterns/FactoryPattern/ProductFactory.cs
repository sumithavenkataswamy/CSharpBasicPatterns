namespace CSharpBasicPatterns.FactoryPattern
{
    public static class ProductFactory
    {
        public static IProductDetail CreateProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "physical":
                    return new PhysicalProduct();
                case "digital":
                    return new DigitalProduct();
                case "service":
                    return new ServiceProduct();
                default:
                    throw new ArgumentException("Invalid product type provided.");
            }
        }
    }

}
