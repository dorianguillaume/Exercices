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

            for (int i = 1; i < file.Length; i++)
            {
                ReleveMensuel releve = new ReleveMensuel(file[i]);
                Console.WriteLine(releve.ToString());
            }
        }
    }
}
