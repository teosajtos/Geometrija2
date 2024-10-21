public class Trokut
{
    Duzina AB;
    Duzina BC;
    Duzina CA;

    public Trokut(Tocka a, Tocka b, Tocka c)
    {
        this.AB = new Duzina(a, b);
        this.BC = new Duzina(b, c);
        this.CA = new Duzina(c, a);
        Console.WriteLine("Trokut je stvoren");
    }

    public double IzracunajOpseg()
    {
        return AB.Duljina() + BC.Duljina() + CA.Duljina();
    }

    public double IzracunajPovrsinu()
    {
        double s = IzracunajOpseg() / 2;
        return Math.Sqrt(s * (s - AB.Duljina()) * (s - BC.Duljina()) * (s - CA.Duljina()));
    }

    public bool JeJednakostranican()
    {
        return AB.Duljina() == BC.Duljina() && BC.Duljina() == CA.Duljina();
    }

    public bool JeJednakokracan()
    {
        return AB.Duljina() == BC.Duljina() || BC.Duljina() == CA.Duljina() || CA.Duljina() == AB.Duljina();
    }

    public bool JePravokutan()
    {
        double a = AB.Duljina();
        double b = BC.Duljina();
        double c = CA.Duljina();

        if (a > b && a > c)
        {
            return a * a == b * b + c * c;
        }
        else if (b > a && b > c)
        {
            return b * b == a * a + c * c;
        }
        else
        {
            return c * c == a * a + b * b;
        }
    }
}