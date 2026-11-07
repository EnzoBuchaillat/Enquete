public class Temoin : Personnage {
    string Temoignage;

    public Temoin(string nom, string description, string temoignage) : base(nom, description){
        Temoignage = temoignage;
    }

    public override void Parler()
    {
        base.Parler();
        Console.WriteLine($"{Nom} : {Temoignage}");
    }
}