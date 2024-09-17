//Ako sa volas
Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();

//Kolko mas rokov
Console.WriteLine("\nKoľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);

//Ake je tvoje oblubene jedlo
Console.WriteLine("\nAké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();

//Konecny verdikt
Console.WriteLine("\nAhoj, tvoje meno je " + meno + ", máš " + vek + " rokov a tvoje obľúbené jedlo je " + jedlo + ".");