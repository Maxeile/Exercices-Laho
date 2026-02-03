using Exercice5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice5;
namespace Exercice5
{
    internal class Hydravion : Vehicule, IMotorise, IVolant, IFlottant
    {
        public Hydravion(string nom, string marque) : base(nom, marque) { }

        public void Demarrer()
        {
            Console.WriteLine("L'hydravion démarre.");
        }

        public void Decoller()
        {
            Console.WriteLine("L'hydravion décolle.");
        }

        public void Atterrir()
        {
            Console.WriteLine("L'hydravion atterrit.");
        }

        public void Naviguer()
        {
            Console.WriteLine("L'hydravion navigue sur l'eau.");
        }
    }
}