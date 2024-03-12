using Aukcioshaz;

Termek t1 = new Termek("Alma",100);

Console.WriteLine(t1);

Vegyesbolt vegyesbolt = new Vegyesbolt();

vegyesbolt.Bevasarlok("C:\\Users\\Elydra\\Desktop\\termekek.txt");
vegyesbolt.MiVanAKosaramban();