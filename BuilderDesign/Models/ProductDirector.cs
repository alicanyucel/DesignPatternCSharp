namespace BuilderDesign.Models;

internal class ProductDirector
{
    public Product BuildProduct(string color,string size,string brand)
    {
        return new ProductBuiilder()
            .SetBrand(brand)
            .SetColor(color)
            .SetSize(size)
            .Build();
    }
}
