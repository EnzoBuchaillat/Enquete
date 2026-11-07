public abstract class Personnage {
    public string Nom {get; private set;}
    public string Description {get; private set;}

    public Personnage(string nom, string description){
        Nom = nom;
        Description = description;
    }

    public virtual void Parler(){}
}