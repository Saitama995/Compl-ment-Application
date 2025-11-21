namespace Exercice_ob_6;

public class Etudiant
{
    public string Nom { get; set; }
    public int Matricule { get; set; }
    public List<decimal> Notes { get; set; }

    public Etudiant(string nom, int matricule, decimal noteInitiale)
    {
        Nom = nom;
        Matricule = matricule;
        Notes = new List<decimal>();   // toujours initialiser la liste
        AjouterNote(noteInitiale);
    }

    public void AjouterNote(decimal note)
    {
        if (note >= 0 && note <= 20)
        {
            Notes.Add(note);
        }
    }

    public decimal CalculerMoyenne()
    {
        if (Notes.Count == 0)
            return 0;

        decimal somme = 0;
        foreach (var n in Notes)
            somme += n;

        return somme / Notes.Count;
    }

    public bool Reussir()
    {
        return CalculerMoyenne() >= 12;
    }

    public  void Afficher()
    {
        decimal moyenne = CalculerMoyenne();
        string statut = Reussir() ? "Réussi" : "Échoué";

        Console.WriteLine($"{Nom} ({Matricule}) - Moyenne : {moyenne:F2} - {statut}");
    }
}
