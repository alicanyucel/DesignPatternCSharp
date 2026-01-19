namespace BuilderDesign;

internal class CarDirector
{
    public Car BuildSportCar()
    {
        return new CarBuilder()
     .SetColor("Kirmizi")
     .SetEnginePower(300)
     .SetInterior("YÜN").Build();
    }
    public Car BuildFamilyCar()
    {
      return new CarBuilder()
     .SetColor("Mavi")
     .SetEnginePower(150)
     .SetInterior("Deri").Build();
    }
}
