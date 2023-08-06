class ElectronicsDetails
{
    public string Brand { get; set; }
    public double Price { get; set; }
    public ElectronicsDetails(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }
    public override string ToString()
    {
        return $"Brand : {Brand} , Price : ${Price}";
    }
}
