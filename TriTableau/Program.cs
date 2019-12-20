using System;

namespace TriTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 15, 250, 20, 30, 50, 15, 16, 80, 90, 2 };

            Console.WriteLine("Voici le tableau avant classement :"+AfficherTableau(tab));
            Console.WriteLine("Voici le tableau apèrs classement "+AfficherTableau(TrierTableau(tab)));
        }

        static string AfficherTableau(int[] tab)
        {
            string message = "";
            foreach(int nb in tab)
            {
                message += " " + nb;
            }

            return message;
        }

        static int[] TrierTableau(int[] tab)
        {
            int[] tabTrie = tab;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = i+1; j < tab.Length; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        int temp = tabTrie[i];
                        tabTrie[i] = tabTrie[j];
                        tabTrie[j] = temp;
                    }
                }
            }
            return tabTrie;
        }
    }
}
