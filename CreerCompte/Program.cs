using System;

namespace CreerCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            CreerCompte();
        }

        static void CreerCompte()
        {

            bool errorLogin = true;
            bool errorMdp = true;

            Console.WriteLine("Veuillez saisir un nom d'utilisateur :");

            while (errorLogin)
            {
                try
                {
                    VerifLogin(Console.ReadLine());
                    errorLogin = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            
            
            Console.WriteLine("Veuillez saisir un mot de passe :");

            while (errorMdp)
            {
                try
                {
                    VerifMdp(Console.ReadLine());
                    errorMdp = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé ");
        }

        static void VerifLogin(string login)
        {
            for (int i = 0; i < login.Length; i++)
            {
                if (login.Length < 5)
                {
                    throw new FormatException("Votre login doit contenir minimum 5 caracères.");              
                } 
            }
        }

        static void VerifMdp(string mdp)
        {
            bool maj = false;
            bool chiffre = false;
            int size = 0;
            foreach (int item in mdp)
            {
                if (item >= 48 && item <= 57)
                {
                    chiffre = true;
                }
                if(item >=65 && item <= 90)
                {
                    maj = true;
                }
                size++;
            }

            if(!chiffre || !maj || size < 6)
            {
                throw new FormatException("Votre mot de passe doit contenir au moins 6 caractères dont 1 majuscule et 1 chiffre ");
            }
        }
    }
}
