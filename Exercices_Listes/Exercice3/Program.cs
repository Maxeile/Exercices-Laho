using System;
using System.Collections.Generic;
using BibliothequeApp;

Bibliotheque biblio = new Bibliotheque();

string choix = "";

while (choix != "0")
{
    Console.Clear(); 
    Console.WriteLine("1 - Ajouter un livre");
    Console.WriteLine("2 - Afficher tous les livres");
    Console.WriteLine("3 - Trouver un livre par titre");
    Console.WriteLine("4 - Trouver un livre par auteur");
    Console.WriteLine("0 - Quitter");

    Console.Write("Votre choix : ");

    choix = Console.ReadLine();

    Console.Clear();


    switch (choix)
    {

        case "1":

            Console.Write("Numéro : ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titre : ");
            string titre = Console.ReadLine();

            Console.Write("Auteur : ");
            string auteur = Console.ReadLine();

            Console.Write("Nombre d'exemplaires : ");
            int exemplaires = int.Parse(Console.ReadLine());

            Livre livre = new Livre(numero, titre, auteur, exemplaires);

            biblio.AjouterLivre(livre);

            break;

        case "2":

            biblio.AfficherTousLesLivres();

            break;

        case "3":

            Console.Write("Titre à rechercher : ");
            string rechercheTitre = Console.ReadLine();


            List<Livre> resultatsTitre = biblio.RechercherParTitre(rechercheTitre);

            if (resultatsTitre.Count == 0)
            {
                Console.WriteLine("Aucun livre trouvé.");
            }
            else
            {
            
                foreach (Livre l in resultatsTitre)
                {
                    Console.WriteLine(l);
                }
            }

            break;

        case "4":

            Console.Write("Auteur à rechercher : ");
            string rechercheAuteur = Console.ReadLine();

            List<Livre> resultatsAuteur = biblio.RechercherParAuteur(rechercheAuteur);

            if (resultatsAuteur.Count == 0)
            {
                Console.WriteLine("Aucun livre trouvé.");
            }
            else
            {
                foreach (Livre l in resultatsAuteur)
                {
                    Console.WriteLine(l);
                }
            }

            break;

        case "0":

            Console.WriteLine("Au revoir !");
            break;

        default:
            Console.WriteLine("Choix invalide.");
            break;
    }

    if (choix != "0")
    {
        Console.WriteLine("\nAppuyez sur Entrée pour continuer");
        Console.ReadLine();
    }
}
