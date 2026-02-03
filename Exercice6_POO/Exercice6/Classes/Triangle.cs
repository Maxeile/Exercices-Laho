using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class Triangle : Figure
    {
        public double Base {  get; set; }
        public double Hauteur { get; set; }

        public Triangle(Point origine, double @base, double hauteur)
            :base(origine)
        {
            Base = @base;
            Hauteur = hauteur;
        }

        public override string ToString()
        {
            return $"Triangle isocèle | Origine: {Origine} | Base: {Base} | Hauteur: {Hauteur}";
        }

    }
}
