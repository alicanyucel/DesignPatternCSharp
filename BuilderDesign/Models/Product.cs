namespace BuilderDesign.Models;

internal class Product
{
    public Product()
    {
        Color = "Kirmizi";
        Size = "Medium";
        Brand = "Nike";
    }
    public string Color { get; set; }   
    public string Size { get; set; }    
    public string Brand { get; set; }
}
