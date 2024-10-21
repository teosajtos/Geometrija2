public class Pravokutnik : GeometrijskiLik
{
    public double Sirina;
    public double Visina;
    

    public Pravokutnik(double sirina, double visina)
    {
        this.Sirina = sirina;
        this.Visina = visina;
        Console.WriteLine("Pravokutnik je stvoren");
    }

    public  double GetPovrsina()
    {
        return Sirina * Visina;
    }

    public  bool GetJeKvadrat()
    {
        return Sirina == Visina;
    }

    public new double Opseg()
    {
        return 2 * (Sirina + Visina);
    }
}
