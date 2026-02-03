using Exercice4;

bool continuer = true;

while (continuer)
{
    Console.Clear();

    Console.WriteLine("        MENU");
    Console.WriteLine("1 - Infos travailleur");
    Console.WriteLine("2 - Infos scientifique");
    Console.WriteLine("0 - Quitter");
    Console.Write("Choix : ");

    string choix = Console.ReadLine();

    Console.Clear();

    switch (choix)
    {
        case "1":
            Travailleur t = new Travailleur(
                "Kent",
                "Clark",
                "0600000000",
                "Superman@gmail.com",
                "Daily Planet",
                "Metropolis",
                "0102030405"
            );

            Console.WriteLine("=== Travailleur ===");
            Console.WriteLine(t.InfosTravailleur());
            break;

        case "2":
            Scientifique s = new Scientifique(
                "Luthor",
                "Lex",
                "0700000000",
                "pasgentil@mail.com",
                "LuthorCorp",
                "Metropolis",
                "0304050607",
                "Physique",
                "Théorique"
            );

            Console.WriteLine("=== Scientifique ===");
            Console.WriteLine(s.InfosScientifique());
            break;

        case "0":
            continuer = false;
            break;

        default:
            Console.WriteLine("Choix invalide");
            break;
    }

    if (continuer)
    {
        Console.WriteLine("\nAppuie sur Entrée pour revenir au menu...");
        Console.ReadLine();
    }
}

