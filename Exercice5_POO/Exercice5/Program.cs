using Exercice5;

Voiture voiture = new Voiture("Clio", "Renault");
VoitureHybride hybride = new VoitureHybride("Prius", "Toyota");
Hydravion hydravion = new Hydravion("Airbus", "Aquaboulevard");

Console.WriteLine(voiture);
Console.WriteLine(hybride);
Console.WriteLine(hydravion);

voiture.Demarrer();

hybride.Demarrer();

hybride.Demarrer();
hybride.Recharger();

hydravion.Demarrer();
hydravion.Naviguer();

Console.ReadLine();