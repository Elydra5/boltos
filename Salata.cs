using Aukcioshaz;

namespace Bolt;

public class Salata : Termek
{

    public int darabszam;
    public Salata(int darabszam) : base("saláta", 200)
    {
        this.darabszam = darabszam;
    }

    public int mennyibeKerul()
    {
        return this.darabszam * this.egysegar;
    }

    public override string ToString()
    {
        string termekString = base.ToString();
        return darabszam + " db " + termekString + " - " + mennyibeKerul() + " Ft";
    }


}