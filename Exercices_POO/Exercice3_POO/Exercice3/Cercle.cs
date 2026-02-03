using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Cercle : Forme
    {
        public double Rayon { get; set; }
    

    public Cercle(double rayon)
            : base("Cercle")
        {
            Rayon = rayon;
        }

        public override double CalculerAire()
        {
            return Math.PI * Rayon * Rayon;
        }

        public override double CalculerPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }
    }
}

