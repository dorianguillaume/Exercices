using System;

namespace Capitales
{
    class Program
    {
        static string[] countries = new string[] { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bulgarie", "Chypre", "Croatie", "Danemark" };
        static string[] capitales = new string[] { "Tirana", "Berlin", "Andorre-La-Vieille", "Viennes", "Bruxelles", "Minsk", "Sofia", "Nicosie", "Zagreb", "Copenhaque" };

        static void Main(string[] args)
        {

           Play();
           //bool play = true;

           // while (play == true)
           // {
           //     Game();
           //     Console.WriteLine("Voulez vous rejouer ? y/n");
           //     string answer = Console.ReadLine();
           //     if (answer == "n")
           //     {
           //         play = false;
           //         Console.WriteLine("GoodBye !");
           //     }
           // }



            /*Console.WriteLine("Quelle est la capitale de l'Espagne ?");
            string answer = Console.ReadLine();

            if (answer == "Madrid")
                Console.WriteLine("Bravo !");
            else
                Console.WriteLine("Mauvaise réponse ..."); */
        }

        static void Game()
        {
            

            int countSuccess = 0;

            for(int i = countries.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Quelle est la capitale de " + countries[i]);
                string answer = Console.ReadLine();

                if (answer == capitales[i])
                {
                    Console.WriteLine("Bravo !");
                    countSuccess++;
                }
                else Console.WriteLine("Mauvaise réponse ... La réponse était : "+capitales[i]);
            }

                Console.WriteLine("Vous avez réussi : {0} questions/10", countSuccess);

           
        }

        static void AskQuestion(int nb)
        {
            string result;

            Console.WriteLine("Quelle est la capitale de " + countries[nb]);
            string answer = Console.ReadLine();

            if (answer == capitales[nb])
            {
                result = "Bravo !";
            }
            else result = "Mauvaise réponse ... La réponse était : " + capitales[nb];

            Console.WriteLine(result);
        }

        static void Play()
        {
            Random random = new Random();

            do
            {
                int randomQuestion = random.Next(10);
                Console.Clear();
                Console.WriteLine("Appuyer sur Echap pour arrêter le jeu");
                AskQuestion(randomQuestion);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();
            Console.WriteLine("\n Merci d'avoir jouer");
        }
    }
}
