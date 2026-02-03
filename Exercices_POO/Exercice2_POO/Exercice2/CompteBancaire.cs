using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class CompteBancaire
    {
        public string Titulaire { get; private set; }
        public string Devise { get; private set; }
        public double Solde { get; protected set; }

        public CompteBancaire(string titulaire, double soldeInitial, string devise)
        {
            Titulaire = titulaire;
            Devise = devise;
            Solde = soldeInitial;
        }

        public bool Deposer(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Un dépôt doit être positif");
                return false;
            }

            Solde += montant;
            return true;
        }

        public bool Retirer(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Un retrait doit être positif");
                return false;
            }

            if (montant > Solde)
            {
                Console.WriteLine("Solde insuffisant");
                return false;
            }

            Solde -= montant;
            return true;
        }

        public string AfficherSolde()
        {
            return $"{Titulaire} possède {Solde} {Devise}";
        }
    }
}
