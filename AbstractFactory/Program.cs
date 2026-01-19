// See https://aka.ms/new-console-template for more information
using AbstractFactory.Models;
using AbstractFactory.Models2;

Console.WriteLine("Abstract Factory");
IYemekFactory factory = new ItalyanMutfagiFactory();
IAnaYemek anaYemek=factory.YemekHazirla();
anaYemek.Hazirla();
ISalata salata=factory.SalataHazirla();
salata.Hazirla();
IMobilyaFactory factory1=new KlasikMobilyaFactory();
IKoltuk koltuk=factory1.KoltukOlustur();
koltuk.BilgiVer();
IMasa masa=factory1.MasaOlustur();
masa.BilgiVer();
