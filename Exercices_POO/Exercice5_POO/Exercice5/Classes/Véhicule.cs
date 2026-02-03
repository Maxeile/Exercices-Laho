using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    internal abstract class Vehicule
    {
        public string Nom {  get; set; }
        public string Marque { get; set; }

        public Vehicule(string nom, string marque)
        {
            Nom = nom;
            Marque = marque;
        }

        public override string ToString()
        {
            return $"{Nom} ({Marque})";
        }

    }
}
