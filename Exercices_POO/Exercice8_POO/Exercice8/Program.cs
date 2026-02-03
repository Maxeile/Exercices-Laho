using Exercice8.Classes;

Arme epee = new Arme("Épée", 5, 5);
Arme baton = new Arme("Bâton magique", 3, 5);
Arme lameRunique = new Arme("Lame runique", 7, 5);


Guerrier guerrier = new Guerrier("Jean", "Warrior", 100, 10, epee);
Mage mage = new Mage("Merlin", "Mage", 80, 8, baton);
GuerrierMage gm = new GuerrierMage("Arthas", "Hybrid", 120, 9, lameRunique);


void AfficherEtat()
{ 
    Console.WriteLine($"Guerrier PV: {guerrier.Pv} | Durabilité arme: {guerrier.Arme.Durabilite}");
    Console.WriteLine($"Mage PV: {mage.Pv} | Durabilité arme: {mage.Arme.Durabilite}");
    Console.WriteLine($"GuerrierMage PV: {gm.Pv} | Durabilité arme: {gm.Arme.Durabilite}");
    Console.WriteLine("================\n");
}


AfficherEtat();

Console.WriteLine("Guerrier attaque Mage");
guerrier.Attaquer(mage);
AfficherEtat();

Console.WriteLine("Mage lance un sort sur Guerrier");
mage.LancerSort(guerrier);
AfficherEtat();

Console.WriteLine("GuerrierMage attaque spéciale sur Mage");
gm.AttaqueSpeciale(mage);
AfficherEtat();

Console.WriteLine("GuerrierMage lance un sort sur Guerrier");
gm.LancerSort(guerrier);
AfficherEtat();


Console.WriteLine("Appuie sur Entrée pour quitter...");
Console.ReadLine();
