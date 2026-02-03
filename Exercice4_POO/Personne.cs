using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal abstract class Personne
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }

        public string Mail { get; set; }

        public Personne (string nom, string prenom, string tel, string mail)
        {
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
        }

        public string Infos()
        {
            return "Nom : " + Nom + "\n" +
                   "Prénom : " + Prenom + "\n" +
                   "Téléphone : " + Tel + "\n" +
                   "Mail : " + Mail + "\n";
        }

    }
}
