using Exercice_Exception;
using Exercice_Exception.Exceptions;

try
{
    int[] notes = { -1, 12, 18, 20 };

    double moyenne = Calculateur.calculMoyenne(notes);

    Console.WriteLine($"Moyenne : {moyenne}");
}
catch (InvalidArrayException e)
{
    Console.WriteLine("Erreur tableau vide : " + e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Erreur note: " + e.Message);
}
