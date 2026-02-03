

List<int> temperature = new List<int>();

int saisie = 0;
int nbInvalides = 0; 

while (saisie != -999)
{
    Console.WriteLine("Entrez une temperature");
    saisie = int.Parse(Console.ReadLine());

    if (saisie == -999)
    {
        break;
    }

    else if (saisie >= -50 && saisie <= 50)
    {
        temperature.Add(saisie);
    }

    else
    {
        nbInvalides++;
    }
}

Console.WriteLine($"\n Nombre de temperatures valides : {temperature.Count}");

Console.WriteLine($"\n Nombre de temperatures invalides : {nbInvalides}");

int min = temperature.Min();
int max = temperature.Max();

Console.WriteLine($"Temperature mini : {min}");
Console.WriteLine($"temperature max : {max}");