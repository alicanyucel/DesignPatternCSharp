namespace BuilderDesign;

internal class CarBuilder
{
    private Car _car;
    public CarBuilder()
    {
        _car=new Car();
    }
    public CarBuilder SetColor(string color)
    {
        _car.Color = color;
        return this;
    }
    public CarBuilder SetEnginePower(int enginePower)
    {
        _car.EnginePower = enginePower;
        return this;
    }
    public CarBuilder SetInterior(string interior)
    {
        _car.Interior = interior;
        return this;
    }
    public Car Build()
    {
        return _car;
    }   
}
