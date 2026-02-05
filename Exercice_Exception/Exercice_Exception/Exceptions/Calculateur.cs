using Exercice_Exception;
using Exercice_Exception.Exceptions;

public class Calculateur
{
    public static double calculMoyenne(int[] notes)
    {

        if (notes.Length == 0)
        {
            throw new InvalidArrayException("Le tableau est vide");
        }


        int somme = 0;


        foreach (int note in notes)
        {
            if (note < 0 || note > 20)
            {
                throw new ArgumentOutOfRangeException("Au moins une note est invalide");
            }

            somme += note;
        }

        double moyenne = (double)somme / notes.Length;

        return moyenne;
    }
}
