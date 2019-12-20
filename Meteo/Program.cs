using System;
using System.IO;
using System.Text;

namespace Meteo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pour gérer problème d'encodage.

            string[] file = File.ReadAllLines("..\\..\\..\\DonnéesMétéoParis.txt", Encoding.UTF8);

            ReleveMensuel test = new ReleveMensuel(file[1]);

            Console.WriteLine(String.Format("{0,10} |{1,10} |{2,10} |{3,10} |{4,10}", "Mois", "T° min", "T° max", "Précip(mm)", "Ensol(H)"));
            Console.WriteLine("------------------------------------------------------------");

            Stats stat = new Stats(DAL.GetRelevesMensuels());

            Console.WriteLine("Temperature max des releves");
            Console.WriteLine(stat.ReleveTempMax);

            Console.WriteLine("Precipitation de l'année 2008");
            Console.WriteLine(stat.GetPrecipitationsAnnee(2008));



            //foreach (var item in DAL.GetRelevesMensuels())
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }
    }
}
