using System.Threading;

class Program
{
    static void Main()
    {
        Archer a = new("Archer");
        Warrior w = new("Warrior");
        Wizard z = new("Wizard");

        a.Shoot(w);
        w.Slash(z);
        z.Cast(a);
        a.Shoot(z);
        w.Slash(a);
        z.Cast(w);
    }
}