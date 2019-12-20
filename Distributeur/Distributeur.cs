using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    public enum Boissons
    {
        Cafe,
        Chocolat,
        Soupe
    }

    class Distributeur
    {

        public int Sucre { get; set; }


        public static string ServirBoisson(Boissons boisson, double solde, int sucre)
        {
            if(sucre > 10)
            {
                sucre = 10;
            }

            switch (boisson)
            {
                case Boissons.Cafe:
                    if (solde < 0.80)
                    {
                        throw new Exception("Votre solde n'est pas suffisant pour du café");
                    }
                    else return "Café avec " + sucre + "g de sucre";
                    break;

                case Boissons.Chocolat:
                    if (solde < 0.75)
                    {
                        throw new Exception("Votre solde n'est pas suffisant pour du chocolat");
                    }
                    else return "Chocolat avec " + sucre + "g de sucre";
                    break;

                case Boissons.Soupe:
                    if (solde < 1)
                    {
                        throw new Exception("Votre solde n'est pas suffisant pour une soupe");
                    }
                    else return "Soupe";
                    break;

                default:
                    throw new Exception("Veuillez choisir une boisson existante");
            }
        }
    }
}
