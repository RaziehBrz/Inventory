class Product<T>
{
    public string Name { get; set; }
    public ProductCategory Category { get; set; }
    public T Details { get; set; }
    public Product(string name, ProductCategory category, T details)
    {
        Name = name;
        Category = category;
        Details = details;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Category : {Category}");
        Console.WriteLine($"Details : {Details}");
    }
}