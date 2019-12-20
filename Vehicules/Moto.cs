using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Moto : Vehicule
    {

        public Moto(string nom, int prix) : base(nom, prix)
        {

        }
        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {
        } 

        public override string Description()
        {
            return "Je suis une moto \n" + base.Description();
        }
    }
}
