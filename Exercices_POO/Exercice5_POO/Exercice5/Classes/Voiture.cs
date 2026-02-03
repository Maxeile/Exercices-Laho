using Exercice5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    internal class Voiture : Vehicule, IMotorise
    {
        public Voiture (string nom, string marque) : base(nom, marque)
        {
        }

        public void Demarrer()
        {
            Console.WriteLine("La voiture démarre");
        }

    }
}
