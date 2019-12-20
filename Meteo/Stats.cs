using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meteo
{
    class Stats
    {
        public List<ReleveMensuel> RelevesMensuels { get; }
        public ReleveMensuel ReleveTempMax { get; }

        public double EnsoleillementMoyenJuillet 
        {
            get
            {
                return RelevesMensuels.Where(r => r.Mois.Month == 7).Average(r => r.Ensoleillement);
            }
        }

        public int NbMoisChauds
        {
            get
            {
                return RelevesMensuels.Count(r => r.TempMax > RelevesMensuels.Average(r => r.TempMax));
            }
        }
        

        //REnvoie un IEnumerable donc on renvoie ça c'est logique en faite !!!

        public IEnumerable<double> PrecipitationsMoyennesParAnne
        {
            get
            {
                return RelevesMensuels.GroupBy(r => r.Mois.Year).Select(r => r.Average(r => r.Precipitation));
            }
        }
        public Stats(List<ReleveMensuel> releves)
        {
            RelevesMensuels = releves;
            ReleveTempMax = releves.OrderBy(r => r.TempMax).LastOrDefault();
        }

        public double GetPrecipitationsAnnee(int annee)
        {

            return RelevesMensuels.Where(r => r.Mois.Year == annee).Sum(r => r.Precipitation);
        }
    }
}
