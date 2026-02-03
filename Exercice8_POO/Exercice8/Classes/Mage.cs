using Exercice8.Interface;

namespace Exercice8.Classes
{
  
    internal class Mage : Personnage, IMagie
    {
      
        public Arme Arme { get; set; }


        public Mage(string nom, string prenom, int pv, int damage, Arme arme)
            : base(nom, prenom, pv, damage)
        {
            Arme = arme;
        }

        public override void Attaquer(Personnage cible)
        {
            int totalDegats = Damage + Arme.DegatSupplementaire;

            cible.Pv -= totalDegats;

            Arme.Utiliser();
        }

        public void LancerSort(Personnage cible)
        {
            int totalDegats = (Damage * 3) + Arme.DegatSupplementaire;

            cible.Pv -= totalDegats;

            Arme.Utiliser();
        }
    }
}
