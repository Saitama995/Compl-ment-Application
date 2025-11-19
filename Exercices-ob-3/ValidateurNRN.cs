namespace Exercices_ob_3
{
    public class ValidateurNRN
    {
        // Méthode principale : vérifie si le NRN est valide
        public bool VerifierNRN(string numero)
        {
            // 1. Vérifier longueur
            if (numero.Length != 11)
            {
                Console.WriteLine("Le numéro doit contenir 11 chiffres.");
                return false;
            }

            // 2. Vérifier que tous les caractères sont des chiffres
            if (!long.TryParse(numero, out _))
            {
                Console.WriteLine("Le numéro doit contenir uniquement des chiffres.");
                return false;
            }

            // 3. Extraire les parties
            string neufPremiers = numero.Substring(0, 9);
            string ccTexte = numero.Substring(9, 2);

            int cc = int.Parse(ccTexte);
            long baseNRN = long.Parse(neufPremiers);

            // 4. Calcul du checksum
            int calcul = 97 - (int)(baseNRN % 97);

            if (calcul == cc)
            {
                Console.WriteLine("NRN valide !");
                return true;
            }
            else
            {
                Console.WriteLine("Checksum invalide.");
                return false;
            }
        }

        // Vérifier les mois
        public bool VerifierMois(int mois)
        {
            return mois >= 1 && mois <= 12;
        }

        // Vérifier les jours
        public bool VerifierJours(int jours)
        {
            return jours >= 1 && jours <= 31;
        }
    }
}