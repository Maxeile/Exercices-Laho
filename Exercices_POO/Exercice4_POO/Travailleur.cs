using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class Travailleur : Personne
     {
        public string NomPro { get; set; }
        public string AdressePro {  get; set; }
        public string TelPro { get; set; }


        public Travailleur(
            string nom,
            string prenom,
            string tel,
            string mail,
            string nomPro,
            string adressePro,
            string telPro)
            :base(nom, prenom, tel, mail)
        {
            NomPro = nomPro;
            AdressePro = adressePro;
            TelPro = telPro;
        }

        public string InfosTravailleur()
        {
            return base.Infos() +
                "Entrprise : " + NomPro + "\n" +
                "Adresse pro : " + AdressePro + "\n" +
                "Téléphone : " + TelPro;

        }




    }
}
