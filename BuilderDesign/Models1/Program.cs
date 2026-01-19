
using BuilderDesign;
using BuilderDesign.Models;

internal class Program
{
    private static void Main(string[] args)
    {
      Car familycar=new CarDirector().BuildFamilyCar();
      Car sportcar=new CarDirector().BuildSportCar();
      Product product=new ProductDirector().BuildProduct("Red","Large","Nike");
    }
}