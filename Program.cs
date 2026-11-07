Lieu bibliotheque = new Lieu("Bibliothèque", "Des livres poussiéreux couvrent les murs.");
Lieu cuisine = new Lieu("Cuisine", "Des tâches de confiture couvrent les murs.");

bibliotheque.Decrire();
cuisine.Decrire();

Personnage Victoria = new Suspect("Victoria Blackwood", "La nièce de la victime, élégante et ruinée. Elle est la seule héritière.", "J’étais dans ma chambre, je lisais. Je n’ai rien entendu à cause de l’orage.");
Personnage Armand = new Suspect("Docteur Armand Fayolle", "Le médecin de famille, nerveux, qui transpire beaucoup.", "J’étais au salon, je jouais aux échecs contre moi-même.");
Personnage Margaux = new Suspect("Margaux Leclerc", "La cuisinière, au service de la famille depuis 20 ans.", "J’étais en cuisine, je préparais le dessert pour demain.");

Personnage Albert = new Temoin("Albert", "Le majordome, impassible, toujours en gants blancs.", "Vers 22 h, j’ai vu de la lumière sous la porte de la bibliothèque. Puis plus rien.");
Personnage Lucie = new Temoin("Lucie", "La jeune femme de chambre, qui a peur de tout.", "J’ai entendu des pas mouillés dans le couloir… quelqu’un venait de dehors.");

Victoria.Parler();
Armand.Parler();
Margaux.Parler();
Albert.Parler();
Lucie.Parler();