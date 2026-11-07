public class Lieu {
    public string Nom {get; private set;}
    public string Description {get; private set;}

    public Lieu(string nom, string description){
        Nom = nom;
        Description = description;
    }

    public void Decrire(){
        Console.WriteLine($"Tu es dans {Nom}. {Description}");
    }
}