using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7.Classes
{
    internal class Lettre
    {
        public User Expediteur {  get; set; }
        public User Destinataire { get; set; }
        public string Contenu { get; set; }

        public Lettre (User expediteur, User destinataire, string contenu)
        {
            Expediteur = expediteur;
            Destinataire = destinataire;
            Contenu = contenu;
        }

        public override string ToString()
        {
            return $"Lettre \n" +
                $"Expediteur : {Expediteur}\n" +
                $"Destinataire : {Destinataire}\n" +
                $"Contenu : {Contenu}";
        }

    }
}
