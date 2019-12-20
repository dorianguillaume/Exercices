using System;
using System.Collections.Generic;

namespace Vehicules
{
    public enum Energies
    {
        Aucune,
        Essence,
        Gazole,
        GPL,
        Electrique
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicule voiture = new Voiture("Audi", Energies.Gazole);
            //Vehicule moto = new Moto("Yamaha", Energies.Essence);
            //Console.WriteLine(voiture.Description());
            //Console.WriteLine(moto.Description());
            //int[] tab = new int[] { 5, 3, 69, 89, 146 };

            Vehicule v1 = new Voiture("Megane", 19000);
            Vehicule v2 = new Moto("Intruder", 13000);
            Vehicule v3 = new Voiture("Enzo", 380000);
            Vehicule v4 = new Moto("Yamaha", 13000);

            //Etape 3 -- Classer par ordre alphabétique
            Dictionary<string, Vehicule> liste1 = new Dictionary<string, Vehicule><string, Vehicule>();
            liste1.Add(v1.Nom, v1);
            liste1.Add(v2.Nom, v2);
            liste1.Add(v3.Nom, v3);
            liste1.Add(v4.Nom, v4);

            foreach (var item in liste1)
            {
                Console.WriteLine(item.Key+" : "+item.Value.Prix);
            }



            //Etpae 4 -- Classer par ordre
            SortedDictionary<Vehicule, string> liste2 = new SortedDictonnary<Vehicule, string>();
            liste2.Add(v1, v1.Nom);
            liste2.Add(v2, v2.Nom);
            liste2.Add(v3, v3.Nom);
            liste2.Add(v4, v4.Nom);

            foreach (var item in liste2)
            {
                Console.WriteLine(item.Value + " : " + item.Key.Prix);
            }
        }
    }
}
