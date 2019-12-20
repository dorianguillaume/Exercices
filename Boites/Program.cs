using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation de 2 objets Boites
            Boite boite1 = new Boite(10, 10, 30, Matieres.Carton);
            Boite boite2 = new Boite(10, 10, 10, Matieres.Carton);

            //Premiere méthode avec 2 objet Boite en paramètre
            if(Boite.Compare(boite1, boite2) == true){
                Console.WriteLine("La Même");
            }
            else Console.WriteLine("Pas la même");

                       
            //Deuxième méthode avec la méthode Compare2 utilisé sur l'objet "boite1" et prenant en paramètre un autre objet boite
            if (boite2.Compare2(boite1))
            {
                Console.WriteLine("La Même");
            }
            else Console.WriteLine("Pas la même");

            Console.WriteLine("Le nombre de boite créé :"+Boite.Compteur);

            //Etape 11 Création d'une boite avec etiquette fragile et etiquette destinataire
            Boite boite3 = new Boite(50, 50, 50);
            boite3.Etiqueter("Patrick", true);
            Console.WriteLine(boite3.EtiquetteDest.ToString());

            //Etape 12 Création d'étiquette puis d'affectation à une boite
            Boite boite4 = new Boite(40, 40, 40);
            Etiquette destinataire = new Etiquette { Texte = "John", Couleur = Couleurs.Blanc, Format = Formats.L };
            Etiquette fragile = new Etiquette("FRAGILE", Couleurs.Rouge, Formats.S);

            boite4.Etiqueter(destinataire, fragile);
            Console.WriteLine(boite4.EtiquetteDest+" et "+boite4.EtiquetteFrag);
        }
    }
}
