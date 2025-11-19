namespace Exercice_ob_4;

public class Produits
{
    public string Nom { get; set; }
    public decimal Prix { get; set; }
    public int Stock { get; set; }
    
    public Produits(string nom, decimal prix, int stock)
    {
        Nom = nom;
        Prix = prix;
        Stock = stock;
        
    }
    //Ajouter stock
    public void AjouterStock (int quantite)
        {
        if (Stock >= quantite)
        {
            quantite++;
            Console.WriteLine($"stockage actuel {quantite}");
        }
        
        }
    public void RetirerStocket (int quantite)
    {
        if (Stock >= quantite)
        {
            Stock -= quantite;
            Console.WriteLine($"stockage actuel {quantite}");
        }
        else
        {
            Console.WriteLine($"stockage insuffisant {quantite}");
        }
        
    }
    // Méthode Acheter
    public double Acheter(int quantite)
    {
        if (quantite <= 0)
        {
            return -1; // quantité invalide
        }

        if (Stock >= quantite)
        {
            Stock -= quantite; 
            decimal total = quantite * Prix;
            return (double)total;    
        }
        else
        {
            return -1;
        }
    }
}