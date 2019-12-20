using System;
using System.Collections.Generic;
using System.Text;

namespace Meteo
{
    class ReleveMensuel
    {
        public DateTime Mois { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Precipitation { get; set; }
        public double Ensoleillement { get; set; }

        public ReleveMensuel(string ligne)
        {
            string[] informations = ligne.Split("\t");

            Mois = DateTime.Parse(informations[0]);
            TempMin = double.Parse(informations[1]);
            TempMax = double.Parse(informations[2]);
            Precipitation = double.Parse(informations[3]);
            Ensoleillement = double.Parse(informations[4]);

        }
        public override string ToString()
        {
            //String Format permet de mettre en forme la chaine de caractère. 
            //{0 --> correspond au numéro de la première chaine indiqué.
            //, 10} --> nombre de caractère à afficher
            return String.Format("{0,10} |{1,10} |{2,10} |{3,10} |{4,10}", Mois.ToString("MM/yyyy"), TempMin, TempMax, Precipitation, Ensoleillement);
        }

        
       
    }
}
