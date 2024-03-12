namespace Aukcioshaz;

public class Termek : IAkciozhato
{

    private string name;
    protected int egysegar;

    public Termek(string name, int egysegar)
    {
        this.name = name;
        this.egysegar = egysegar;
    }

    public int AkciosAr()
    {
        return 1000;
    }

    public int mennyibeKerul()
    {
        return this.egysegar;
    }


    public override string ToString()
    {
        return name + " - " + egysegar.ToString() + " Ft";
    }

}