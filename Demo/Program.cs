using System;

namespace Demo
{
    class Program
    {
        enum Sexes { Femme, Homme}
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();

            //Console.WriteLine(Description("Marion", 1994, Sexes.Femme));
            //Console.WriteLine(Description("Roger", 1962, Sexes.Homme));

            
  

        }

        static void Demo1()
        {

            Console.Write("écriture");
            Console.Write(" de mots");
            Console.Write(" les uns à la suite des autres");

            Console.WriteLine();
            string name = Console.ReadLine();
            Console.WriteLine("Bonjour " + name + ". Quel est ton année de naissance ?");
            string answer = Console.ReadLine();


            int yearBirth = Convert.ToInt32(answer);
            int age = 2019 - yearBirth;
            Console.WriteLine("Vous allez avoir " + age + " ans");

            Console.WriteLine("Bonjour {0}, vous allez avoir {1} ans", name, age);

            //Console.WriteLine("Bonjour {0}, vous allez avoir {1} ans", name, age);
            //Console.WriteLine($"Bonjour {name}, vous allez avoir {age} ans");

            string message;
            message = (yearBirth % 4 == 0) ? "C'est une année bissextile" : "C'est non !";
            Console.WriteLine(message);

            string tranche = "Vous êtes dans la tranche d'âge : ";

            if (age < 25)
                Console.WriteLine(tranche + "moins de 25 ans");
            else if (age >= 25 && age < 35)
                Console.WriteLine(tranche + "25 - 30 ans");
            else
                Console.WriteLine(tranche + "plus de 35 ans");


            if (yearBirth < 1900 || yearBirth > 2019)
                Console.WriteLine("Vous devez saisir une année valide");
        }

        static void Demo2()
        {
            string text;
            string sentence;
            int nbSentences = 0, nbWords;

            sentence = "Le C# est un langage moderne et puissant.";
            text = sentence;
            text += " Il est utilisé pour toutes sortes d'applications :\n";
            text += " - application console\n";
            text += " - application fenêtrée avec Winforms et WPF\n";
            text += " - application mobile avec Xamarin\n";

            Console.WriteLine(text);

            int[] tab = new int[3] { 3, 4, 40 };
            Console.WriteLine(tab.Length);

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Position {0} : {1}", i, tab[i]);
            }


            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    nbSentences++;
                }
            }
            Console.WriteLine(nbSentences);


        }

        static void Demo3()
        {
            string sentence = "Le C# c'est génial";

            int n = CountWords(sentence);

            Console.WriteLine($"La phrase \"{sentence}\" comporte {n} mots");

        }

        static int CountWords(string p)
        {
            int nbWords = 1;

            for (int i = 0; i < p.Length; i++)
            {
                if(p[i] == ' ')
                {
                    nbWords++;
                }
            }

            return nbWords;
        }

        static string Description(string name, int year, Sexes sexe)
        {
            string message;

            int age = 2019 - year;

            if (sexe == Sexes.Femme)
            {
                message = "Bonjour Madame " + name + ", vous avez " + age + " ans !";
            }
            else message = "Bonjour Monsieur " + name + ", vous avez " + age + " ans !";
            return message;
        }
    }
}
