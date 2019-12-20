using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Meteo
{
    //DAL --> Pour Data Access Layer
    static class DAL
    {
        public const string PATH = "..\\..\\..\\DonnéesMétéoParis.txt";

        public static List<ReleveMensuel> GetRelevesMensuels()
        {
            string[] file = File.ReadAllLines(PATH, Encoding.UTF8);
            List<ReleveMensuel> releves = new List<ReleveMensuel>();

            for (int i = 1; i < file.Length; i++)
            {
                ReleveMensuel releve = new ReleveMensuel(file[i]);
                releves.Add(releve);
            }

            return releves;
        }
    }
}
