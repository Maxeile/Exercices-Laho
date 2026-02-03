using Exercice7.Classes;
using System;
using System.Collections.Generic;

List<User> users = new List<User>();
Lettre lettre = null;

while (true)
{
    Console.Clear();
    Console.WriteLine("1 - Créer un utilisateur");
    Console.WriteLine("2 - Afficher les utilisateurs");
    Console.WriteLine("3 - Rédiger une lettre");
    Console.WriteLine("4 - Afficher la lettre");
    Console.WriteLine("0 - Quitter");
    Console.Write("Choix : ");

    string choix = Console.ReadLine();
    Console.Clear();

    if (choix == "0") break;

    switch (choix)
    {
        case "1":
            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();

            Console.Write("Numéro rue : ");
            int numeroRue = int.Parse(Console.ReadLine());

            Console.Write("Nom rue : ");
            string nomRue = Console.ReadLine();

            Console.Write("Ville : ");
            string ville = Console.ReadLine();

            Console.Write("Code postal : ");
            string codePostal = Console.ReadLine();

            Adresse adresse = new Adresse(numeroRue, nomRue, ville, codePostal);
            users.Add(new User(nom, prenom, adresse));

            Console.WriteLine("Utilisateur créé");
            break;

        case "2":
            if (users.Count == 0)
            {
                Console.WriteLine("Aucun utilisateur");
            }
            else
            {
                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine($"{i} - {users[i]}");
                }
            }
            break;

        case "3":
            if (users.Count < 2)
            {
                Console.WriteLine("Il faut au moins 2 utilisateurs.");
                break;
            }

            Console.WriteLine("Choisis l'expéditeur (index) :");
            for (int i = 0; i < users.Count; i++)
                Console.WriteLine($"{i} - {users[i]}");
            int idxExp = int.Parse(Console.ReadLine());

            Console.WriteLine("Choisis le destinataire (index) :");
            for (int i = 0; i < users.Count; i++)
                Console.WriteLine($"{i} - {users[i]}");
            int idxDest = int.Parse(Console.ReadLine());

            Console.WriteLine(" Contenu de la lettre :");
            string contenu = Console.ReadLine();

            lettre = new Lettre(users[idxExp], users[idxDest], contenu);

            Console.WriteLine("Lettre rédigée ");
            break;

        case "4":
            if (lettre == null)
            {
                Console.WriteLine("Aucune lettre");
            }
            else
            {
                Console.WriteLine(lettre);
            }
            break;

        default:
            Console.WriteLine("Choix invalide");
            break;
    }

    Console.WriteLine("\nAppuie sur Entrée pour continuer");
    Console.ReadLine();
}
