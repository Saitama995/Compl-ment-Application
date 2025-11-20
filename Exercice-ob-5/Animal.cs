namespace Exercice_ob_5;

public class Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public string EspeceType {get; set; }

    public Animal(string nom, int age, string especeType)
    {
        Nom = nom;
        Age = age;
        EspeceType = especeType;
    }
    public virtual void Fairebruit()
    {
        Console.WriteLine($"{Nom} l'animal fait du bruit");
    }
    public class Chien : Animal
    {
        public Chien(string nom, int age, string especeType) : base(nom, age, especeType)
        {
        }

        public override void FaireDuBruit()
        {
            Console.WriteLine(" Woof! Woof!");
            base.Fairebruit();
        }
    }

    public class Chat : Animal
    {
        public Chat(string nom, int age) : base(nom, age)
        {
        }

        public override void FaireDuBruit()
        {
            Console.WriteLine(" Miaou! Miaou!");
            base.Fairebruit();
        }
        
    }

    public class Oiseau : Animal
    {
        public Oiseau(string nom, int age) : base(nom, age)
        {
        }

        public override void FaireDuBruit()
        {
            Console.WriteLine(" Piou! Piou!");
            base.Fairebruit();
        }
        
    }

    public void Manger(string nourriture)
    {
       Console.WriteLine($"{Nom}donner de la {nourriture}.");
    }

    public virtual void FaireDuBruit()
    {
        throw new NotImplementedException();
    }
}

