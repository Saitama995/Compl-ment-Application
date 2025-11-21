using Exercice_ob_6;
public class Classe
{
    public string Nom { get; set; }
    public List<Etudiant> etudiants = new List<Etudiant>();

    public Classe(string nom)
    {
        Nom = nom;
    }

    public void AjouterEleve(Etudiant e)
    {
        etudiants.Add(e);
    }

    public decimal MoyenneClasse()
    {
        if (etudiants.Count == 0)
            return 0;
        decimal sommeMoyenne = 0;
        foreach (var e in etudiants)
        {
            sommeMoyenne += e.CalculerMoyenne();
        }

        return sommeMoyenne / etudiants.Count;
    }

    public object Etudiants { get; }

    public Etudiant MeilleurEtudiant()
        {
            if (etudiants.Count == 0) return null!;
            Etudiant meilleur = etudiants[0];
            foreach (Etudiant etudiant in etudiants)
            {
                if (etudiant.CalculerMoyenne() > meilleur.CalculerMoyenne())
                {
                    meilleur = etudiant;
                }
            }
            return meilleur;
        }

        public int NbReussis()
        {
            int c = 0;
            foreach (Etudiant etudiant in etudiants)
            {
                if (etudiant.Reussir())
                    c++;
            }
            return c;
        }

        public void AfficherTous()
        {
            Console.WriteLine($"\n📚 Classe : {Nom}");
            Console.WriteLine("=== Étudiants ===");

            foreach (Etudiant etudiant in etudiants)
            {
                etudiant.Afficher();
            }

            Console.WriteLine($"\nMoyenne de classe : {MoyenneClasse():F2}");
            Console.WriteLine($"Réussis : {NbReussis()}/{etudiants.Count}");
            Console.WriteLine($"Meilleur étudiant(e) : {MeilleurEtudiant().Nom}");
        }
}    
