
using BuilderDesign;

internal class Program
{
    private static void Main(string[] args)
    {
      Car familycar=new CarDirector().BuildFamilyCar();
      Car sportcar=new CarDirector().BuildSportCar();
    }
}