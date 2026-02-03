using Exercice2;

CompteBancaire compte = new CompteBancaire("Maxim", 18000, "EUR");
compte.Deposer(200);
compte.Retirer(150);
Console.WriteLine(compte.AfficherSolde());

CompteEpargne epargne = new CompteEpargne("Bob", 500, "EUR", 0.03);
epargne.Deposer(200);
double interets = epargne.CalculerInterets();
Console.WriteLine($"Intérêts: {interets} {epargne.Devise}");
Console.WriteLine(epargne.AfficherSolde());

CompteCourant courant = new CompteCourant("Charlie", 100, "EUR", 200);
courant.RetirerAvecDecouvert(300);
Console.WriteLine(courant.AfficherSolde());

