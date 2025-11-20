namespace Exercice_ob_5;

public class Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public string EspeceType { get; set; }

    public Animal(string nom, int age, string especeType)
    {
        Nom = nom;
        Age = age;
        EspeceType = especeType;
    }

    public virtual void Fairebruit()
    {
        Console.WriteLine($"{Nom} l'animal fait du bruit ");
    }

    public virtual void Manger()
    {
        Console.WriteLine($" pour {Nom} qui va le manger");
    }

    //public abstract void Fairebruit();
    
    
    public class Chien : Animal 
    {
        public Chien(string nom, int age, string especeType) : base(nom, age, especeType)
        {
        }

        public override void Fairebruit()
            {
                Console.Write(" Woof! Woof! ");
                base.Fairebruit();
            }

        public override void Manger()
        {
            Console.Write(" Pâtée ");
            base.Manger();
        }
    }
    

    public class Chat : Animal
    {
        public Chat(string nom, int age, string especeType) : base(nom, age, especeType)
        {
        }

        public override void Fairebruit()
            {
                Console.WriteLine(" Miaou! Miaou! ");
                base.Fairebruit();
            }

        public override void Manger()
        {
            Console.Write(" croquette ");
            base.Manger();
        }

        }
    

    public class Oiseau : Animal
    {
        public Oiseau(string nom, int age, string especeType) : base(nom, age, especeType)
        {
        }

        public override void Fairebruit()
            {
                Console.WriteLine(" Piou! Piou! ");
                base.Fairebruit();
            }

        public override void Manger()
        {
            Console.Write(" graine ");
            base.Manger();
        }

        }

 //   public void Manger(string nourriture)
    //{
   //     Console.WriteLine($"{Nom} va manger {nourriture}.");
 //   }

}
