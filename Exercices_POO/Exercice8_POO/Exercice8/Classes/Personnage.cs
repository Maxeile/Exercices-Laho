namespace Exercice8.Classes
{
    internal abstract class Personnage
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Pv { get; set; }
        public int Damage { get; set; }

        public Personnage(string nom, string prenom, int pv, int damage)
        {
            Nom = nom;
            Prenom = prenom;
            Pv = pv;
            Damage = damage;
        }
        public abstract void Attaquer(Personnage cible);

        public override string ToString()
        {
            return $"{Nom} {Prenom} | PV: {Pv} | DMG: {Damage}";
        }
    }
}

