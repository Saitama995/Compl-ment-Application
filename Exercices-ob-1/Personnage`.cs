namespace Exercices_ob
{
    public class Personnage
    {
        // Propriétés
        public string Nom { get; set; }
        public string Classe { get; set; }
        public int PuntsDevie { get; set; }
        public int Niveau { get; set; }
        public int Experience { get; set; }

        // Constructeur
        public Personnage(string nom, string classe, int puntsDevie, int niveau, int experience)
        {
            Nom = nom;
            Classe = classe;
            PuntsDevie = puntsDevie;
            Niveau = niveau;
            Experience = experience;
        }

        // Méthode pour afficher le personnage
        public void Presenter()
        {
            Console.WriteLine("== Fiche du personnage ==");
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Classe : {Classe}");
            Console.WriteLine($"Points de vie : {PuntsDevie}");
            Console.WriteLine($"Niveau : {Niveau}");
            Console.WriteLine($"Experience : {Experience}");
        }

        // Méthode pour gagner de l'expérience
        public void PrendreExp(int exp)
        {
            Console.WriteLine($"{Nom} gagne {exp} points d'expérience !");

            // Chaque 100 XP → +1 niveau
            while (exp >= 100 && Niveau < 250)
            {
                Niveau++;
                Console.WriteLine($"{Nom} passe au niveau {Niveau} !");
            }
        }
    }
}