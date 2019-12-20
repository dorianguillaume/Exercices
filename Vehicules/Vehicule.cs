using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Vehicules
{
    class Vehicule
    {
        public string Nom { get; }
        public int NbRoues { get; }

        public Energies Energie { get; }

        public int Prix { get; }

        public Vehicule(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
        }
        public Vehicule(string nom, int roues, Energies energie)
        {
            Nom = nom;
            Energie = energie;
            NbRoues = roues;
        }

        public virtual string Description()
        {
            return ($"Véhicule {Nom} roule sur {NbRoues} roues et à l'énergie {Energie}");
        }

      
        //public int CompareTo([AllowNull] Vehicule other)
        //{
        //    if (Prix > other.Prix)
        //    {
        //        return 1;
        //    }
        //    else if (Prix == other.Prix)
        //    {
        //        return 0;
        //    }
        //    else return -1;
        //

    }
}
