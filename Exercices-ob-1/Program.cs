
// création personnage 


using Exercices_ob;

var person1 = new Personnage();

person1.Nom = "John";
person1.Classe = "Magicien";
person1.PuntsDevie = Convert.ToInt32("5");
person1.Niveau = Convert.ToInt32("0");
person1.Experience = Convert.ToInt32("0");

var person2 = new Personnage();

    person2.Nom = "martin";
    person2.Classe = "Archer";
    person2.PuntsDevie = Convert.ToInt32("3");
    person2.Niveau = Convert.ToInt32("1");
    person2.Experience = Convert.ToInt32("0");

    person1.Presenter();
    {
        person1.PrendreExp(0);
    }
