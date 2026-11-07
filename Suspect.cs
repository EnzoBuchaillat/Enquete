public class Suspect : Personnage {
    string Alibi;

    public Suspect(string nom, string description, string alibi) : base(nom, description){
        Alibi = alibi;
    }

    public override void Parler()
    {
        base.Parler();
        Console.WriteLine($"{Nom} : \" {Alibi} \"");

    }
}