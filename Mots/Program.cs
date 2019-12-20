using System;

namespace Mots
{
    class Program
    {

        static void Main(string[] args)
        {

            int nbLetters;
            int nbConsonant;
            int nbVowel;
            string word = Console.ReadLine();
            CountLetters(word, out nbLetters, out nbConsonant, out nbVowel);
            Console.WriteLine("\""+word+"\" comporte "+nbLetters+" lettres, "+nbConsonant+" consonnes, "+nbVowel+" voyelles");
        }

        static void CountLetters(string word, out int nbLetter, out int nbConsonant, out int nbVowel)
        {
            nbConsonant = 0;
            nbVowel = 0;
            nbLetter = word.Length;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'y')
                {
                    nbVowel++;
                }
                else nbConsonant++;               
            }            


        }
    }
}
