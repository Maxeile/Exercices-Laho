using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8.Classes
{
    internal class Arme
    {
        public string NomArme { get; set; }
        public int DegatSupplementaire { get; set; }
        public int Durabilite { get; set; }

        //Propriété 
        public bool Cassee {get => Durabilite == 0; }


        public Arme(string nomArme, int degatSupplementaire, int durabilite)

        {
            NomArme = nomArme;
            DegatSupplementaire = degatSupplementaire;
            Durabilite = durabilite;
        }


        public void Utiliser()
        {
            if (Durabilite > 0)
            {
                Durabilite--;
            }
        }
   
    }
}
