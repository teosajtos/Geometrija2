
using System;
public class Kruznica(double radius) : GeometrijskiLik
{
    public double Radius = radius;

    public new double Povrsina()
    {
        throw new NotImplementedException();
    }

    public double IzracunajPovrsinu()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public new double Opseg()
    {
        throw new NotImplementedException();
    }

    public double IzracunajOpseg()
    {
        return 2 * Math.PI * Radius;
    }


}