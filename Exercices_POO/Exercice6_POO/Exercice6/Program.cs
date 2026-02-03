using Exercice6;


Figure figure = null;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== FIGURES ===");
    Console.WriteLine("1 - Créer un Carré");
    Console.WriteLine("2 - Créer un Rectangle");
    Console.WriteLine("3 - Créer un Triangle");
    Console.WriteLine("4 - Afficher la figure");
    Console.WriteLine("5 - Déplacer la figure");
    Console.WriteLine("0 - Quitter");
    Console.Write("Choix : ");

    string choix = Console.ReadLine();
    Console.Clear();

    if (choix == "0") break;

    switch (choix)
    {
        case "1":
            figure = new Carre(new Point(0, 0), 5);
            Console.WriteLine("Carré créé (origine 0,0 côté 5).");
            break;

        case "2":
            figure = new Rectangle(new Point(0, 0), 10, 4);
            Console.WriteLine("Rectangle créé (origine 0,0 longueur 10 largeur 4).");
            break;

        case "3":
            figure = new Triangle(new Point(0, 0), 8, 6);
            Console.WriteLine("Triangle créé (origine 0,0 base 8 hauteur 6).");
            break;

        case "4":
            if (figure == null)
                Console.WriteLine("Aucune figure créée.");
            else
                Console.WriteLine(figure.ToString());
            break;

        case "5":
            if (figure == null)
            {
                Console.WriteLine("Aucune figure créée.");
                break;
            }

            Console.Write("dx : ");
            double dx = double.Parse(Console.ReadLine());
            Console.Write("dy : ");
            double dy = double.Parse(Console.ReadLine());

            figure.Deplacement(dx, dy);
            Console.WriteLine("Déplacement effectué.");
            Console.WriteLine(figure.ToString());
            break;

        default:
            Console.WriteLine("Choix invalide.");
            break;
    }

    Console.WriteLine("\nAppuie sur Entrée pour continuer...");
    Console.ReadLine();
}

