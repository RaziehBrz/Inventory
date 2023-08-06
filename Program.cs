internal class Program
{
    private static void Main(string[] args)
    {
        var inventory = new List<Product<object>>()
        {
            new Product<object>("Laptop" , ProductCategory.Electronics , new ElectronicsDetails("Dell" , 899.99)) ,
            new Product<object>("T-Shirt" , ProductCategory.Clothing , new ClothingDetails("Medium" , "Cotton")) ,
            new Product<object>("Book" , ProductCategory.Books , "Introduction to c# Programming") ,
            new Product<object>("Apple", ProductCategory.Food , "Red Delicious")
        };

        foreach (var Product in inventory)
        {
            Console.WriteLine("-------------");
            Product.DisplayInfo();
            Console.WriteLine("-------------");
        }
    }
}