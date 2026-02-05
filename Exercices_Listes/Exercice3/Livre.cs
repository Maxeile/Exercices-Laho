namespace BibliothequeApp
{
    internal class Livre
    {
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int ExemplairesDispo { get; set; }

        public Livre(int numero, string titre, string auteur, int exemplairesDispo)
        {
            Numero = numero;
            Titre = titre;
            Auteur = auteur;
            ExemplairesDispo = exemplairesDispo;
        }

        public override string ToString()
        {
            return $"[{Numero}] {Titre} - {Auteur} | Exemplaires: {ExemplairesDispo}";
        }
    }
}
