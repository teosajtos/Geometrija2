public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("-------------------------Trokut------------------------------ ");

        Trokut abc = new Trokut(new Tocka(0, 0), new Tocka(0, 3), new Tocka(4, 0));
        Console.WriteLine("Opseg trokuta: " + abc.IzracunajOpseg());
        Console.WriteLine("Povrsina trokuta: " + abc.IzracunajPovrsinu());
        Console.WriteLine("Je li pravokutan? " + abc.JePravokutan());
        Console.WriteLine("Je li jednakostranican? " + abc.JeJednakostranican());
        Console.WriteLine("Je li jednakokracan? " + abc.JeJednakokracan());
        
        
        Console.WriteLine("-------------------------Pravokutnik-------------------------- ");
        
        Pravokutnik pravokutnik = new Pravokutnik(5, 10);
        Console.WriteLine("Opseg pravokutnika: " + pravokutnik.Opseg());
        Console.WriteLine("Povrsina Pravokutnika: " + pravokutnik.GetPovrsina());
        Console.WriteLine("Je li kvadrat? " + pravokutnik.GetJeKvadrat());
    }
}
