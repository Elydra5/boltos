using Aukcioshaz;

namespace Bolt;

public class RohadtParadicsom : Termek, IAkciozhato
{

    public double tomeg;
    public RohadtParadicsom(double tomeg, int egysegar) : base("Rohadt paradicsom", egysegar)
    {
        this.tomeg = tomeg;
    }

    public new int mennyibeKerul()
    {
        var ar = tomeg * egysegar;
        return (int)Math.Round(ar);
    }

    public new int AkciosAr()
    {
        var akciosAr = mennyibeKerul() * 0.8;
        return (int)Math.Round(akciosAr);
    }

    public new string toString()
    {
        return base.ToString().Replace("Termek", "rohadt paradicsom").Replace("Ft", "").Trim() + " - " + mennyibeKerul().ToString() + " Ft";
    }

}