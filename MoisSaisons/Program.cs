using System;

namespace MoisSaisons
{
    class Program
    {
        [Flags]
        public enum Saisons
        {
            Aucun = 0,
            Hiver = 1,
            Printemps = 2,
            Ete = 4,
            Automne = 8
        }

        [Flags]
        public enum Mois
        {
            Aucun = 0,
            Janvier = 1,
            Fevrier = 2,
            Mars = 4,
            Avril = 8,
            Mai = 16,
            Juin = 32,
            Juillet = 64,
            Aout = 128,
            Septembre = 256,
            Octobre = 512,
            Novembre = 1024,
            Decembre = 2048
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(SaisonsDuMois(Mois.Mars));
            
        }

        public static Saisons SaisonsDuMois(Mois mois)
        {

            Mois moisHiver = Mois.Decembre | Mois.Janvier | Mois.Fevrier | Mois.Mars;
            Mois moisPrintemps = Mois.Mars | Mois.Avril | Mois.Mai | Mois.Juin;
            Mois moisEte = Mois.Juin | Mois.Juillet | Mois.Aout | Mois.Septembre;
            Mois moisAutomne = Mois.Septembre | Mois.Octobre | Mois.Novembre | Mois.Decembre;

            Saisons saison = Saisons.Aucun;

            if((mois & moisHiver) == mois)
            {
                saison |= Saisons.Hiver;
            }
            if ((mois & moisPrintemps) == mois)
            {
                saison |= Saisons.Printemps;
            }
            if ((mois & moisEte) == mois)
            {
                saison |= Saisons.Ete;
            }
            if ((mois & moisAutomne) == mois)
            {
                saison |= Saisons.Automne;
            }

            return saison;
        }
    }
}
