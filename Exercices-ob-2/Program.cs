// See https://aka.ms/new-console-template for more information

using Exercices_ob_2;

var client1 = new Comptebancaire(numero: "BE02 556 556 5676", 50, "Balieu", "Martin");

client1.AfficherSolde();
client1.deposer(15);
client1.AfficherSolde();
client1.Retirer(80);
client1.AfficherSolde();