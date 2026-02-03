using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Chien
    {     
        //Attributs non statiques
        private string _nom;
        private string _race;
        private int _age;

        public string Nom { get { return _nom; } set { _nom = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public static string NomChenil { get { return _nomChenil; } set { _nomChenil = value; } }
        public static int NbChiens { get { return _nbChiens} set { }
        // Attrinuts statiques
        private static string _nomChenil;
        private static int _nbChiens;


        public Chien (string nom, string race, int age)
        {
            this._nom = nom;
            this._race = race;
            this._age = age;

            NbChiens++;
        }

    }
}
