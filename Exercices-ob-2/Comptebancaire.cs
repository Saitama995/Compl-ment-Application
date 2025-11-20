using System.ComponentModel.Design;

namespace Exercices_ob_2;

//Propriété 
public class Comptebancaire
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Numerodecompte { get; set; }
    private decimal Solde { get; set; }


    //Constructeur 
    public Comptebancaire(string numero, decimal soldeInitial, string nom, string prenom)
    {
        Numerodecompte = numero;
        Nom = nom;
        Prenom = prenom;
        Solde = soldeInitial;
    }

    public void deposer(decimal montant)

    {
        if (montant > 0)
        {
            Solde += montant;
        }
    }

    public bool Retirer(decimal montant)
    {
        if (montant > 0 && montant <= Solde)
        {
            Solde -= montant;
            return true;
        }
        else
        {
            Console.WriteLine("Le solde est insuffisant");
            return false;
        }
    }

    public void AfficherSolde()
    {
        //Console.WriteLine($"Solde de débart {soldeInitial}");
        Console.WriteLine($"Mr {Nom} il vous reste sur votre compte le montant de {Solde} !");
    }
}