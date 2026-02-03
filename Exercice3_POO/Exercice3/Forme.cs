using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal abstract class Forme
    {
        public string Nom { get; set; }

        public Forme (string nom)
        {
            Nom = nom;      
        }

        public abstract double CalculerAire();
        public abstract double CalculerPerimetre();

        public string Infos()
        {
            return
                "Forme :" + Nom + "\n" +
                "Aire : " + CalculerAire() + "\n" +
                "Perimetre : " +CalculerPerimetre();
        }   




    }
}
