using Aukcioshaz;
using System.Globalization;

namespace Bolt;

public class Vegyesbolt
{
    private static List<Termek> raktar = new List<Termek>();

    public void Bevasarlok(string filePath)
    {
        List<Termek> termekek = new List<Termek>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        int egysegar = int.Parse(parts[1]);
                        double mennyiseg;
                        if (!double.TryParse(parts[2], NumberStyles.Any, CultureInfo.InvariantCulture, out mennyiseg))
                        {
                            Console.WriteLine($"Hibás formátum: {parts[2]}");
                            continue;
                        }
                        if (name.ToLower() == "salata")
                        {
                            raktar.Add(new Salata(1));
                        }
                        else if (name.ToLower() == "paradicsom")
                        {
                            raktar.Add(new RohadtParadicsom(mennyiseg, egysegar));
                        }
                        else
                        {
                            Console.WriteLine($"Ismeretlen termék: {name}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Hibás sor formátum: {line}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hiba történt a fájl beolvasása közben: {e.Message}");
        }

    }

    public void MiVanAKosaramban()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("kosar.txt"))
            {
                foreach (Termek termek in raktar)
                {
                    string kosarElem = termek.ToString();
                    if (termek is IAkciozhato)
                    {
                        kosarElem += $" (Akciós ár: {((IAkciozhato)termek).AkciosAr()} Ft)";
                    }
                    sw.WriteLine(kosarElem);
                }
            }
            Console.WriteLine("A kosár tartalma kiírva a 'kosar.txt' fájlba.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hiba történt a fájl írása közben: {e.Message}");
        }
    }

}