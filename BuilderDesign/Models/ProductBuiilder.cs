namespace BuilderDesign.Models;

internal class ProductBuiilder
{
    private Product _product;
    public ProductBuiilder()
    {
        _product = new Product();
    }
    public ProductBuiilder SetColor(string color)
    {
        _product.Color = color;
        return this;
    }
    public ProductBuiilder SetSize(string size)
    {
        _product.Size = size;
        return this;
    }
    public ProductBuiilder SetBrand(string brand)
    {
        _product.Brand = brand;
        return this;
    }
    public Product Build()
    {
        return _product;
    }   
}