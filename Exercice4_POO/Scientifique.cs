using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class Scientifique : Travailleur
    {
        public string Discipline { get; set; }
        public string TypeScientifique { get; set; }

        public Scientifique(
            string nom,
            string prenom,
            string tel, 
            string mail,
            string nomPro,
            string adressePro,
            string telPro,
            string discipline,
            string typeScientifique)
            :base(nom, prenom, tel, mail, nomPro, adressePro, telPro)
        {
            Discipline = discipline;
            TypeScientifique = typeScientifique;
        }

        public string InfosScientifique()
        {
            return InfosTravailleur() +
                "\nDiscipline :" + Discipline + "\n" +
                "Type :" + TypeScientifique;
                
        }




    }
}
