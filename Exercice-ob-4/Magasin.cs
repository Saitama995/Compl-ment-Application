public class Magasin {
    public string Nom { get; set; }
    private List produits = new List();
    
    public Magasin(string nom) {
        Nom = nom;
    }
    
    public void AjouterProduit<Produit>(Produit p) {
        produits.Add(p);
        Console.WriteLine($"✅ {p.Nom} ajouté au magasin");
    }
    
    public void AfficherProduits() {
        Console.WriteLine($"\n📦 Produits du magasin {Nom}:");
        foreach (var produit in produits) {
            Console.WriteLine($"  - {produit.Nom} : {produit.Prix}€ (Stock: {produit.Stock})");
        }
    }
    
    public Produit TrouverProduit<Produit>(string nom) {
        foreach (var produit in produits) {
            if (produit.Nom == nom) {
                return produit;
            }
        }
        return null;
    }
}