
//Exercice1

using System.Reflection.Metadata;

SortedSet<string>noms = new SortedSet<string>();
noms.Add("Sonic");
noms.Add("Knuckles");
noms.Add("Tails");
noms.Add("Amy");
noms.Add("Rose");
noms.Add("Rose");
noms.Add("Sonic");
noms.Add("Tails");
noms.Add("Shadow");


Console.WriteLine("Liste des participants : ");

foreach(string nom in noms)
{
    Console.WriteLine(nom);
}

string recherche = "Shadow";

if (noms.Contains(recherche))
{
    Console.WriteLine($"{recherche} est dans la compet ");
}
else
{
    Console.WriteLine($"{recherche} n'est pas dans la compet ");
}


//Exercice2

Queue<string> file = new Queue<string>();
file.Enqueue("Bob");
file.Enqueue("Carlo");
file.Enqueue("Patrick");
file.Enqueue("Plancton");

while (file.Count > 0)
{
    Console.WriteLine("\n Entrée pour prochain client");
    Console.ReadLine();


    string client = file.Dequeue();

    Console.WriteLine(file.Dequeue());

    Console.WriteLine($"Client en cours : ");

    Console.WriteLine($"Clients restant : {file.Count}");
}

Console.WriteLine("C'est la pause");
Console.ReadLine();


//Exercice3

Dictionary<string, int> notes = new Dictionary<string, int>();

notes["Maxim"] = 20;
notes["Axel"] = 19;
notes["Alex"] = 15;
notes["Alix"] = 14;

notes["Alix"] = 11;

Console.WriteLine($"Note d'Alix : {notes["Alix"]}");

foreach (var note in notes)
{
    Console.WriteLine($"{note.Key} :{note.Value}");
}

Console.ReadLine();