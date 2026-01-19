namespace BuilderDesignPatternTest.Models;

public class Home
{
    public Home()
    {
        Foundation = "Beton Temel";
        Walls = "Tuğla Duvar";
        Roof = "Çatı";
        Interior = "Standart İç Döşeme";
    }
    public string Foundation { get; set; } //Temel
    public string Walls { get; set; } //Duvar
    public string Roof { get; set; } //Çatı
    public string Interior { get; set; } //İş Döşeme

    public string PrintDetails()
    {
        return "Ev inşaatı verdiğiniz şartlar ile tamamlandı";
    }
}
