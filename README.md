# Enquete

Un petit jeu d'enquête en console, écrit en C#.

Une nuit d'orage, Lord Blackwood est retrouvé mort dans la bibliothèque de son manoir. Le joueur explore les pièces, interroge les suspects et les témoins, et doit découvrir qui est le coupable.

> Projet perso en cours : je le code pour apprendre le C# et la programmation orientée objet.

## L'histoire

**Les lieux** : le hall, la bibliothèque, le salon et la cuisine, reliés entre eux par des sorties (nord, sud, est, ouest).

**Les suspects**
- **Victoria Blackwood** : la nièce de la victime, ruinée et seule héritière
- **Docteur Armand Fayolle** : le médecin de famille, nerveux
- **Margaux Leclerc** : la cuisinière, au service de la famille depuis 20 ans

**Les témoins**
- **Albert** : le majordome
- **Lucie** : la femme de chambre

## Où j'en suis

- [x] Les lieux, avec leur description et leurs sorties
- [x] Les personnages : suspects (avec un alibi) et témoins (avec un témoignage)
- [x] Placer les personnages dans les pièces
- [ ] Se déplacer d'une pièce à l'autre en tapant une direction
- [ ] Interroger les personnages présents
- [ ] Accuser un suspect et savoir si on a trouvé le coupable

## Ce que le projet m'apprend

- Les **classes** et les **propriétés** en C#
- L'**héritage** : `Suspect` et `Temoin` héritent de la classe abstraite `Personnage`
- Le **polymorphisme** : chaque type de personnage redéfinit `Parler()` à sa façon
- Les collections : `List` pour les personnages d'une pièce, `Dictionary` pour ses sorties

## Lancer le jeu

Il faut le [SDK .NET](https://dotnet.microsoft.com/download) (version 10).

```bash
git clone https://github.com/EnzoBuchaillat/Enquete.git
cd Enquete
dotnet run
```

## Structure

| Fichier | Rôle |
| --- | --- |
| `Program.cs` | Crée le manoir, les personnages, et lance le jeu |
| `Lieu.cs` | Une pièce : nom, description, personnages présents et sorties |
| `Personnage.cs` | Classe abstraite commune à tous les personnages |
| `Suspect.cs` | Un suspect, qui donne son alibi |
| `Temoin.cs` | Un témoin, qui raconte ce qu'il a vu ou entendu |
