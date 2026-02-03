using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Rectangle : Forme
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle (double longueur, double largeur)
        :base ("Rectangle")

        {
            Longueur = longueur;
            Largeur = largeur;
        }


        public override double CalculerAire()
        {
            return Longueur * Largeur;
        }

        public override double CalculerPerimetre()
        {
           return 2 * (Longueur +  Largeur);
        }
    }
}
