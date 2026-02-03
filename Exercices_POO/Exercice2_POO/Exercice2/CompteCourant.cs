namespace Exercice2
{
    internal class CompteCourant : CompteBancaire
    {
        public double DecouvertAutorise { get; private set; }

        public CompteCourant(string titulaire, double soldeInitial, string devise, double decouvertAutorise)
            : base(titulaire, soldeInitial, devise)
        {
            DecouvertAutorise = decouvertAutorise;
        }

        public bool RetirerAvecDecouvert(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Un retrait doit être positif");
                return false;
            }

            if (Solde - montant < -DecouvertAutorise)
            {
                Console.WriteLine("Dépassement du découvert autorisé");
                return false;
            }

            Solde -= montant;
            return true;
        }
    }
}
