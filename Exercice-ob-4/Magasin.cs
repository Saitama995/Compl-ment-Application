using Exercice_ob_4;

public class Magasin
{
    public string Nom { get; set; }
    public List<Produit> ListProduits = new List<Produit>();

    public Magasin(string nom)
    {
        Nom = nom;
    }

    public void AjouterProduit(Exercice_ob_4.Produit p)
    {
        ListProduits.Add(p);
        Console.WriteLine($"✅ {p.Nom} ajouté au magasin");
    }

    public void AfficherProduits()
    {
        Console.WriteLine($" Produits du magasin {Nom}:");
        foreach (var produit in ListProduits)
        {
            Console.WriteLine($"  - {produit.Nom} : {produit.Prix}€ (Stock: {produit.Stock})");
        }
    }

    public Produit TrouverProduit(string nom)
    {
        foreach (var produit in ListProduits)
        {
            if (produit.Nom == nom)
            {
                return produit;
            }
        }
        return null;
    }
}