using System;
using System.Collections.Generic;

namespace BibliothequeApp
{
    internal private class Bibliotheque
    {
        List<Livre> _livres = new List<Livre>();

        public void AjouterLivre(Livre livre)
        {
            _livres.Add(livre);

            Console.WriteLine("Livre ajouté !");
        }

        public bool SupprimerLivreParNumero(int numero)
        {
            foreach (Livre livre in _livres)
            {

                if (livre.Numero == numero)
                {
                    _livres.Remove(livre);

                    return true; 
                }
            }

            return false;
        }

        public void AfficherTousLesLivres()
        {
    
            if (_livres.Count == 0)
            {
                Console.WriteLine("Aucun livre trouvé T_T");
                return;
            }

   
            foreach (Livre livre in _livres)
            {
                Console.WriteLine(livre); 
            }
        }

        public List<Livre> RechercherParTitre(string titre)
        {          
            List<Livre> resultats = new List<Livre>();

            foreach (Livre livre in _livres)
            {

                if (livre.Titre.ToLower().Contains(titre.ToLower()))
                {
                    resultats.Add(livre);
                }
            }

            return resultats;
        }

        public List<Livre> RechercherParAuteur(string auteur)
        {
            List<Livre> resultats = new List<Livre>();

            foreach (Livre livre in _livres)
            {
                if (livre.Auteur.ToLower().Contains(auteur.ToLower()))
                {
                    resultats.Add(livre);
                }
            }

            return resultats;
        }
    }
}
