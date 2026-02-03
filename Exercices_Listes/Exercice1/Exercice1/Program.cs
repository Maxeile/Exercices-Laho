List<string> mots = new List<string>();
string saisie = "";

while (saisie != "stop")
{
    Console.WriteLine("Entrez un mot");
    saisie = Console.ReadLine();

    if (saisie != "stop")
    {
        mots.Add(saisie);
    }
}

Console.WriteLine($"\n Nombre total de mots : {mots.Count}");

Console.WriteLine("Liste des mots :");

foreach(string mot in mots)
{
    Console.WriteLine(mot);
}

Console.ReadLine();