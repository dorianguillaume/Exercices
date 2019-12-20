using System;
using System.IO;

namespace Note
{
    class Program
    {
        static void Main(string[] args)
        {
            SaisirNote();
        }

        public static void SaisirNote()
        {
            Console.WriteLine("Veuillez saisir un texte");
            string texte = Console.ReadLine();
            Console.WriteLine("Veuillez saisir un chemin de fichier");
            string chemin = Console.ReadLine();

            try
            {
                EnregistrerNote(texte, chemin);

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Le répertoire spécifié n'existe pas");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void EnregistrerNote(string texte, string chemin)
        {
            StreamWriter outputFile = null;
            using (outputFile = new StreamWriter(chemin + "\\test.txt", true))
            {
                outputFile.WriteLine(texte);
            }

            //try
            //{
            //    outputFile = new StreamWriter(chemin + "\\test.txt", true);
            //    outputFile.WriteLine(texte);
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("Le répertoire spécifié n'existe pas");
            //}
            //finally
            //{
            //    if (outputFile != null) outputFile.Close();
            //}
        }
    }
}
