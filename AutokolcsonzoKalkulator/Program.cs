//2.feladat
List<int> szamossz = new List<int>();
double kedvezmeny = 0;
int legnagyobb = 0;
string legjobbnev = "";
for (int i=0;i<4;i++)
{
    Console.WriteLine($"{i + 1}. bérlés adatai");
    Console.Write("\tBérlő neve: ");
    string nev =Console.ReadLine();
    Console.Write("\tKölcsönzött napok (db): ");
    int napok = int.Parse(Console.ReadLine());
    bool vip = true;
    Console.Write("\tVIP tag (true/false): ");
    string valasz = Console.ReadLine();
    int ossz = napok * 12000;
    if (valasz =="false")
    {
        vip = false;
    }

    if (vip || napok > 7)
    {
        kedvezmeny = 0.15;
    }
    else if (napok >= 3 && napok<7 )
    {
        kedvezmeny = 0.05;
    }
    else
    {
        kedvezmeny = 0;
    }
    int ujossz = ossz - (int)(ossz*kedvezmeny);
    if (ujossz>legnagyobb)
    {
        legnagyobb = ujossz;
        legjobbnev = nev;
    }
    szamossz.Add(ujossz);
}
int napiossz = 0;
string status = "";
for (int i = 0; i < szamossz.Count; i++)
{
    napiossz += szamossz[i];
}
double atlag = napiossz/4.0; 
if (napiossz >= 200000)
{
    status = "Kiemelkedő forgalmú nap!";
}
else if (100000<napiossz && napiossz<200000)
{
    status = "Átlagos forgalmú nap.";
}
else
{
    status="Gyenge forgalmú nap."; 
}
Console.WriteLine("Rögzített kölcsönzések díjai:");
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"\t- {i + 1}. bérlés: {szamossz[i]} Ft");
}

Console.WriteLine($"Napi teljes bevétel: {napiossz} Ft");
Console.WriteLine($"Átlagos kölcsönzési díj: {atlag:F0} Ft");
Console.WriteLine($"Napi értékelés: {status}");
Console.WriteLine($"Legjobb vásárló: {legjobbnev} összege: {legnagyobb} Ft-al");
