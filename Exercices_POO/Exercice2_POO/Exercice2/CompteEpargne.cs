using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class CompteEpargne : CompteBancaire
    {
        public double TauxInteret { get; private set; }

        public CompteEpargne(string titulaire, double soldeInitial, string devise, double tauxInteret)
            : base(titulaire, soldeInitial, devise)
        {
            TauxInteret = tauxInteret;
        }

        public double CalculerInterets()
        {
            return Solde * TauxInteret;
        }
    }
}
