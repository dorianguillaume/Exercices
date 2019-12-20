using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Voiture : Vehicule
    {
        public Voiture(string nom, int prix) : base(nom, prix)
        {

        }
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {
        }

        public override string Description()
        {
            return "Je suis une voiture \n"+base.Description();  
        }

        public override string ToString()
        {
            return ($"{Nom} à {NbRoues} roues, qui roule avec {Energie}");
        }
    }
}
